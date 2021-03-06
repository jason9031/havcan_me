﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using HalconDotNet;

namespace halcon_me1
{
    public partial class halcon_me : Form
    {
        private bool IO_ThreadStop = true;
        private Thread IO_Thread = null;

        private bool AcquireImageStop = true;
        private Thread AcquireImage = null;

        private const int m_textLineLimit = 200;

        //图像交互参数
        private int ImageWidth = 640;
        private int ImageHeight = 480;
        private GraphInteractive GraphInteractiveObect = null;


        //图像采集参数
        private HObject ho_Image = null;
        private HImage background_image = null;
        private HTuple hv_AcqHandle = null;
        private HObject TempImage = null;


        //图像标定
        private string CameraInnerParameterFile = null;
        private string CameraOuterParameterFile = null;


        //图像定位
        private HDrawingObject ObjectRoi = null;
        private HTuple hv_ModelID = null;

        //运动控制
        // private Motion MotionObject = null;
        private uint ProductSignal = 0;

        //尺寸测量
        private bool TestState = false;
        private HTuple hv_FirstLineBeginRowModal = null;
        private HTuple hv_FirstLineBeginColumnModal = null;
        private HTuple hv_FirstLineEndRowModal = null;
        private HTuple hv_FirstLineEndColumnModal = null;
        private HTuple hv_SecondLineBeginRowModal = null;
        private HTuple hv_SecondLineBeginColumnModal = null;
        private HTuple hv_SecondLineEndRowModal = null;
        private HTuple hv_SecondLineEndColumnModal = null;

        private HTuple hv_MetrologyHandle = null;
        private HDevProgram Program = null;
        private HDevProcedure Procedure = null;
        private HDevProcedureCall ProcedureCall = null;
        public HDevEngine MyEngine = null;
        private delegate void FlushOutPut(string msg);
        public halcon_me()
        {
            InitializeComponent();
            CounterTMT.AppEvents.Instance.UpdateScreenEvent += LogToScreen;
            GraphInteractiveObect = new GraphInteractive();
            Program = new HDevProgram();
            Procedure = new HDevProcedure();
            MyEngine = new HDevEngine();
            HOperatorSet.GenEmptyObj(out ho_Image);
            HOperatorSet.GenEmptyObj(out TempImage);
        }
        private void LogToScreen(string st)
        {
            if (this.DisplayLog_textBox.InvokeRequired)
            {
                var flush = new FlushOutPut(LogToScreen);
                this.Invoke(flush, new object[] { st });
            }
            else
            {
                var msg = string.Format("{0}   {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff"), st);

                string nowtext = string.Empty;
                if (DisplayLog_textBox.Lines.Length >= m_textLineLimit)
                {
                    // DisplayLog_textBox.Lines.

                    //将textbox中的文本按换行符分割bai成数组du
                    String[] lines = DisplayLog_textBox.Lines;
                    //把删除的行剔除, 重新组成新的字符串zhi
                    String text = "";
                    for (int iLcnt = 0; iLcnt < lines.Length; iLcnt++)
                    {
                        //假设删除最后行
                        if (iLcnt >= (m_textLineLimit - 2))
                        {
                            continue;
                        }
                        text += lines[iLcnt] + (iLcnt == lines.Length - 1 ? "" : "\r\n"); //最后一行不添加换行符
                    }
                    nowtext = st + "\r\n" + text;
                    DisplayLog_textBox.Text = nowtext;
                }
                else
                {
                    this.DisplayLog_textBox.Text.Insert(0, st + "\r\n");
                }
            }
        }


        private void BtnFun1_Click(object sender, EventArgs e)
        {
            HObject RawImage;
            string path = Directory.GetCurrentDirectory() + @"\pic\plastic_mesh_09.png";
            if (File.Exists(path))
                HOperatorSet.ReadImage(out RawImage, path);
            else
                MessageBox.Show("File No exist");
        }
        /// <summary>
        /// load function 相机打开 打开一次即可 窗体打开时候加载图像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Halcon_me_Load(object sender, EventArgs e)
        {
            HOperatorSet.SetSystem("width", ImageWidth);
            HOperatorSet.SetSystem("height", ImageHeight);
            HOperatorSet.SetSystem("use_window_thread", "true");

            //IO线程
            IO_Thread = new Thread(new ThreadStart(IO_ThreadFunction));
            IO_Thread.IsBackground = true;
            IO_Thread.Priority = ThreadPriority.Normal;
            IO_Thread.Start();

            //图像采集线程
            AcquireImage = new Thread(new ThreadStart(AcquireImageFunction));


            CreateGraphicInteractionWindow(ref GraphInteractiveObect, ref VideoWindow_hWindowControl, ImageWidth, ImageHeight);


            LoadInnerCameraParameter(null, null);
            LoadOuterCameraParameter(null, null);

            // 相机打开 打开一次即可 窗体打开时候加载图像
            HOperatorSet.GenEmptyObj(out ho_Image);//

            //Image Acquisition 02: Code generated by Image Acquisition 02
            HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8,
                "rgb", -1, "false", "default", "[0]", 0, -1, out hv_AcqHandle);

            HOperatorSet.GrabImageStart(hv_AcqHandle, -1);

            HOperatorSet.DispObj(ho_Image, GraphInteractiveObect.halconWindow.HalconWindow);
            if (File.Exists(Directory.GetCurrentDirectory() + @"\ini\Templete.shm"))
            {
                HOperatorSet.ReadShapeModel(Directory.GetCurrentDirectory() + @"\ini\Templete.shm", out hv_ModelID);
            }

            if (File.Exists(Directory.GetCurrentDirectory() + @"\ini\MetrologyHandle.mtr"))
            {
                HOperatorSet.ReadMetrologyModel(Directory.GetCurrentDirectory() + @"\ini\MetrologyHandle.mtr", out hv_MetrologyHandle);
            }
            LoadHalconEnginee();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

#if (NormalTest)
            MotionObject.InitMotionCard();
#endif


        }

        private void LoadHalconEnginee()
        {
            HOperatorSet.SetSystem("filename_encoding", "utf8");

            string CurrentPath = Directory.GetCurrentDirectory();
            MyEngine.SetProcedurePath(CurrentPath);

            string ProgramPathString = Directory.GetCurrentDirectory() + @"\ini\MeasureSize.hdev";
            string ProcedureCallName = "MeasureSizeLibrary";
            Program = new HDevProgram(ProgramPathString);
            Procedure = new HDevProcedure(Program, ProcedureCallName);
            ProcedureCall = new HDevProcedureCall(Procedure);

        }

        /// <summary>
        /// 创建交互式窗口
        /// </summary>
        /// <param name="GraphInteractiveObect"></param>
        /// <param name="WindowControl"></param>
        /// <param name="ImageWidth"></param>
        /// <param name="ImageHeight"></param>
        private void CreateGraphicInteractionWindow(ref GraphInteractive GraphInteractiveObect, ref HWindowControl WindowControl, HTuple ImageWidth, HTuple ImageHeight)
        {
            //视频窗口
            if (GraphInteractiveObect.halconWindow == null)
            {
                //GraphInteractiveObect.halconWindow.HalconID = WindowControl.HalconID;
                GraphInteractiveObect.halconWindow = WindowControl;
                GraphInteractiveObect.InitHalconDialog(ImageWidth, ImageHeight);
            }
        }

        /// <summary>
        /// IO线程函数
        /// </summary>
        private void IO_ThreadFunction()
        {
            IO_ThreadStop = false;
            while (!IO_ThreadStop)
            {
#if (NormalTest)
                ProductSignal = MotionObject.ReadInputPortByPort(1);
#endif

            }
        }
        private void DrawRectangle(object sender, EventArgs e)
        {
            HTuple width, height;
            background_image = new HImage(ho_Image);
            background_image.GetImageSize(out width, out height);
            VideoWindow_hWindowControl.HalconWindow.SetPart(0, 0, height.I - 1, width.I - 1);
            VideoWindow_hWindowControl.HalconWindow.AttachBackgroundToWindow(background_image);


            GraphInteractiveObect.halconWindow.Focus();
            GraphInteractiveObect.graphic_stackClear();
            VideoWindow_hWindowControl.HalconWindow.ClearWindow();

            ObjectRoi = HDrawingObject.CreateDrawingObject(HDrawingObject.HDrawingObjectType.RECTANGLE2, ImageHeight / 2, ImageWidth / 2, 0, 300, 150);
            ObjectRoi.SetDrawingObjectParams("color", "yellow");
            GraphInteractiveObect.AttachDrawObj(ObjectRoi);
        }
        private void SearchObject(HTuple TempModelID, HObject SearchImage)
        {
            try
            {
                HTuple hv_RefRow = null, hv_RefColumn = null, hv_RefAngle = null, hv_Score = null;
                HOperatorSet.FindShapeModel(SearchImage, TempModelID, (new HTuple(0)).TupleRad(), (new HTuple(360)).TupleRad(), 0.5, 1, 0.5, "least_squares", (new HTuple(6)).TupleConcat(1), 0.75, out hv_RefRow, out hv_RefColumn, out hv_RefAngle, out hv_Score);

                //获取模版中对象轮廓
                HObject ho_ModelContours;
                HOperatorSet.GenEmptyObj(out ho_ModelContours);
                HOperatorSet.GetShapeModelContours(out ho_ModelContours, hv_ModelID, 1);

                //构建一个仿射变换矩阵
                HTuple hv_HomMat2D = null;
                HOperatorSet.VectorAngleToRigid(0, 0, 0, hv_RefRow, hv_RefColumn, 0, out hv_HomMat2D);

                //对图像左上角对象轮廓进行仿射变换，将轮廓平移到产品位置
                HObject ho_TransContours;
                HOperatorSet.GenEmptyObj(out ho_TransContours);
                HOperatorSet.AffineTransContourXld(ho_ModelContours, out ho_TransContours, hv_HomMat2D);


                GraphInteractiveObect.graphic_stackClear();
                VideoWindow_hWindowControl.HalconWindow.ClearWindow();

                HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "yellow");
                HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "margin");
                HOperatorSet.DispObj(SearchImage, GraphInteractiveObect.halconWindow.HalconWindow);
                HOperatorSet.DispObj(ho_TransContours, GraphInteractiveObect.halconWindow.HalconWindow);

                HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "blue");
                HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "fill");
                HOperatorSet.DispLine(GraphInteractiveObect.halconWindow.HalconWindow, hv_RefRow, hv_RefColumn - 100, hv_RefRow, hv_RefColumn + 100);
                HOperatorSet.DispLine(GraphInteractiveObect.halconWindow.HalconWindow, hv_RefRow - 100, hv_RefColumn, hv_RefRow + 100, hv_RefColumn);

                this.ModelRow_textBox.Text = hv_RefRow.ToString();
                this.txtRow.Text = hv_RefRow.ToString();
                this.ModelColumn_textBox.Text = hv_RefColumn.ToString();
                this.txtCol.Text = hv_RefColumn.ToString();
                this.ModelAngle_textBox.Text = hv_RefAngle.ToString();
                this.txtAngle.Text = hv_RefAngle.ToString();

                HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "yellow");
                HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "margin");
                saveImage("Pos");
                ho_ModelContours.Dispose();
                ho_TransContours.Dispose();

            }
            catch (HalconException ex)
            {

            }

        }
        private void CreateTemplete(object sender, EventArgs e)
        {
            HTuple CenterRow = ObjectRoi.GetDrawingObjectParams("row");
            HTuple CenterColumn = ObjectRoi.GetDrawingObjectParams("column");
            HTuple Phi = ObjectRoi.GetDrawingObjectParams("phi");
            HTuple Lenght1 = ObjectRoi.GetDrawingObjectParams("length1");
            HTuple Lenght2 = ObjectRoi.GetDrawingObjectParams("length2");

            HObject ModelRegion;
            HOperatorSet.GenEmptyObj(out ModelRegion);
            HOperatorSet.GenRectangle2(out ModelRegion, CenterRow, CenterColumn, Phi, Lenght1, Lenght2);

            HObject TemplateImage;
            HOperatorSet.GenEmptyObj(out TemplateImage);
            HOperatorSet.ReduceDomain(ho_Image, ModelRegion, out TemplateImage);

            HTuple hv_ParameterValue = null, hv_ParameterName = null;
            HOperatorSet.DetermineShapeModelParams(TemplateImage, "auto", 0, (new HTuple(360)).TupleRad(), 0.9, 1.1, "auto", "use_polarity", "auto", "auto", "all", out hv_ParameterName, out hv_ParameterValue);
            HTuple MinContrast = hv_ParameterValue[7].I.ToString();
            HTuple Location_MaxContrast = hv_ParameterValue[5].I.ToString();

            HOperatorSet.CreateShapeModel(TemplateImage, 0, 0, (new HTuple(360)).TupleRad(), "auto", "auto", "use_polarity", int.Parse(Location_MaxContrast), int.Parse(MinContrast), out hv_ModelID);

            if (File.Exists(Directory.GetCurrentDirectory() + @"/Templete.shm"))
            {
                File.Delete(Directory.GetCurrentDirectory() + @"/Templete.shm");
                HOperatorSet.WriteShapeModel(hv_ModelID, Directory.GetCurrentDirectory() + @"/Templete.shm");
            }
            else
            {
                HOperatorSet.WriteShapeModel(hv_ModelID, Directory.GetCurrentDirectory() + @"/Templete.shm");
            }

            ModelRegion.Dispose();
            TemplateImage.Dispose();

        }
        /// <summary>
        /// 图像采集线程函数
        /// </summary>
        private void AcquireImageFunction()
        {
            AcquireImageStop = false;
            while (!AcquireImageStop)
            {

                if (chkTest.Checked)
                {
                    try
                    {
                        ho_Image.Dispose();
                        HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                        HOperatorSet.DispObj(ho_Image, GraphInteractiveObect.halconWindow.HalconWindow);
                    }
                    catch (HalconException halExp)
                    {
                        string strLogToScreen = halExp.ToString();
                        UpdateLogMessage(strLogToScreen);
                    }
                }
                //2.对抓取的图像进行校正
               else  if (this.CalirationImage_checkBox1.Checked)
                {

                    ho_Image.Dispose();
                    HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                    TempImage = CalibrationImage(ho_Image);
                    HOperatorSet.DispObj(TempImage, GraphInteractiveObect.halconWindow.HalconWindow);

                    //3.视觉定位
                    if (this.ProductLocation_checkBox.Checked)
                    {
                        //3.视觉定位
                        ho_Image.Dispose();
                        HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                        SearchObject(hv_ModelID, TempImage);
                        HOperatorSet.DispObj(TempImage, GraphInteractiveObect.halconWindow.HalconWindow);

                    }

                    //4.调用算法进行测试
                    if (ProductSignal == 1 && (!TestState))
                    {
                        ho_Image.Dispose();
                        HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);
                        TestState = true;
                        ProductSignal = 0;


                        //4.调用算法进行测试
                        //HTuple hv_TempleteRow = double.Parse(this.ModelRow_textBox.Text);
                        //HTuple hv_TempleteColumn = double.Parse(this.ModelColumn_textBox.Text);
                        //HTuple hv_TempleteAngle = double.Parse(this.ModelAngle_textBox.Text);
                        HTuple hv_TempleteRow = double.Parse(this.txtRow.Text);
                        HTuple hv_TempleteColumn = double.Parse(this.txtCol.Text);
                        HTuple hv_TempleteAngle = double.Parse(this.txtAngle.Text);


                        HObject ho_MeasureRegion;
                        HOperatorSet.GenEmptyObj(out ho_MeasureRegion);

                        HTuple Distance = null;
                        HTuple MeasureDown = double.Parse(this.txtLow.Text);
                        HTuple MeasureTop = double.Parse(this.txtUpper.Text);
                        string Result = MeasureAlgorithm(TempImage, MeasureDown, MeasureTop, hv_MetrologyHandle, hv_TempleteRow, hv_TempleteColumn, hv_TempleteAngle, out Distance, out ho_MeasureRegion);

                        HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "red");
                        HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "margin");
                        HOperatorSet.DispObj(TempImage, GraphInteractiveObect.halconWindow.HalconWindow);
                        HOperatorSet.DispObj(ho_MeasureRegion, GraphInteractiveObect.halconWindow.HalconWindow);


                        if (Result == "PASS")
                        {
                            this.DisplayResult_label.Text = "合格";
                            this.DisplayResult_label.ForeColor = Color.Green;
                            this.Distance_textBox.Text = Distance.ToString();
                            this.Distance_textBox2.Text = Distance.ToString();
                            this.Distance_label.Text = Distance.ToString();
#if (NormalTest)
                            MotionObject.WriteOutputByPort(4,1);
#endif
                        }
                        if (Result == "NG")
                        {
                            this.DisplayResult_label.Text = "不合格";
                            this.DisplayResult_label.ForeColor = Color.Red;
                            this.Distance_textBox.Text = Distance.ToString();
                            this.Distance_textBox2.Text = Distance.ToString();
                            this.Distance_label.Text = Distance.ToString();
#if (NormalTest)
                            MotionObject.WriteOutputByPort(2, 1);//吹气
                            MotionObject.WriteOutputByPort(3, 1);//NG指示灯
#endif
                        }

                        ho_MeasureRegion.Dispose();

                        TestState = false;
                    }
                }

            }
        }
        /// <summary>
        /// 加载测量算法
        /// </summary>
        private string MeasureAlgorithm(
            HObject RawImage, HTuple Parameter1, HTuple Parameter2,
            HTuple hv_MetrologyHandle, HTuple hv_ModelRow,
            HTuple hv_ModelColumn, HTuple hv_ModelAngle,
            out HTuple Distance, out HObject ho_MeasureRegion)
        {
            try
            {

                ProcedureCall.SetInputIconicParamObject("Image", RawImage);                          //设置输入图像

                ProcedureCall.SetInputCtrlParamTuple("MetrologyHandle", hv_MetrologyHandle);         //测量句柄

                ProcedureCall.SetInputCtrlParamTuple("ModelCenterRow", hv_ModelRow);                 //定位行坐标

                ProcedureCall.SetInputCtrlParamTuple("ModelCenterColumn", hv_ModelColumn);           //定位列坐标

                ProcedureCall.SetInputCtrlParamTuple("ModelAngle", hv_ModelAngle);                    //定位角度

                ProcedureCall.Execute();  //执行外部函数

            }
            catch (HDevEngineException Ex)
            {
                ho_MeasureRegion = null;
                Distance = 0;
                MessageBox.Show(Ex.Message, "A图像引擎错误");

            }
            catch (Exception Ex)
            {
                ho_MeasureRegion = null;
                Distance = 0;
                MessageBox.Show(Ex.Message, "Windows错误");
            }

            Distance = ProcedureCall.GetOutputCtrlParamTuple("ResultValue");                  //获取测量值

            ho_MeasureRegion = ProcedureCall.GetOutputIconicParamObject("MeasureRegion");     //获取测量区域

            //Distance = double.Parse(this.PixelDangLiang_textBox.Text) * Distance * 1000;

            Distance = double.Parse(this.txtP.Text) * Distance * 1000;

            string Result = null;
            if (Distance >= Parameter1 && Distance <= Parameter2)
            {
                Result = "PASS";
            }
            else
            {
                Result = "NG";
            }

            return Result;
        }

        private void DrawStartLine(object sender, EventArgs e)
        {
            GraphInteractiveObect.halconWindow.Focus();
            HOperatorSet.SetLineWidth(GraphInteractiveObect.halconWindow.HalconWindow, 2);
            HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "green");
            HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "margin");

            HObject ho_FirstLine;
            HOperatorSet.GenEmptyObj(out ho_FirstLine);
            ho_FirstLine.Dispose();

            HOperatorSet.DrawLineMod(GraphInteractiveObect.halconWindow.HalconWindow, 200, 600, 400, 600, out hv_FirstLineBeginRowModal, out hv_FirstLineBeginColumnModal, out hv_FirstLineEndRowModal, out hv_FirstLineEndColumnModal);
            HOperatorSet.GenRegionLine(out ho_FirstLine, hv_FirstLineBeginRowModal, hv_FirstLineBeginColumnModal, hv_FirstLineEndRowModal, hv_FirstLineEndColumnModal);
            HOperatorSet.DispObj(ho_FirstLine, GraphInteractiveObect.halconWindow.HalconWindow);
        }

        private void DrawStopLine(object sender, EventArgs e)
        {
            GraphInteractiveObect.halconWindow.Focus();
            HOperatorSet.SetLineWidth(GraphInteractiveObect.halconWindow.HalconWindow, 2);
            HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "green");
            HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "margin");

            HOperatorSet.DrawLineMod(GraphInteractiveObect.halconWindow.HalconWindow, 200, 600, 400, 600, out hv_SecondLineBeginRowModal, out hv_SecondLineBeginColumnModal, out hv_SecondLineEndRowModal, out hv_SecondLineEndColumnModal);

            HObject ho_SecondLine;
            HOperatorSet.GenEmptyObj(out ho_SecondLine);
            ho_SecondLine.Dispose();
            HOperatorSet.GenRegionLine(out ho_SecondLine, hv_SecondLineBeginRowModal, hv_SecondLineBeginColumnModal, hv_SecondLineEndRowModal, hv_SecondLineEndColumnModal);
            HOperatorSet.DispObj(ho_SecondLine, GraphInteractiveObect.halconWindow.HalconWindow);
        }

        private void DrawMeasureModel(object sender, EventArgs e)
        {
            try
            {
                if (hv_FirstLineBeginRowModal == null || hv_FirstLineBeginColumnModal == null ||
                hv_FirstLineEndRowModal == null || hv_FirstLineEndColumnModal == null ||
                hv_SecondLineBeginRowModal == null || hv_SecondLineBeginColumnModal == null ||
                hv_SecondLineEndRowModal == null || hv_SecondLineEndColumnModal == null)
                {
                    MessageBox.Show("请先画直线");
                    return;
                }

                //创建测量模型
                HOperatorSet.CreateMetrologyModel(out hv_MetrologyHandle);

                //设置测量对象的图像大小
                HTuple hv_Width = null, hv_Height = null;
                HOperatorSet.GetImageSize(ho_Image, out hv_Width, out hv_Height);
                HOperatorSet.SetMetrologyModelImageSize(hv_MetrologyHandle, hv_Width, hv_Height);

                //添加测量直线对象到测量模型中
                HTuple hv_Line1 = null, hv_Line2 = null, hv_MetrologyLine = null;
                hv_Line1 = new HTuple();
                hv_Line1 = hv_Line1.TupleConcat(hv_FirstLineBeginRowModal);
                hv_Line1 = hv_Line1.TupleConcat(hv_FirstLineBeginColumnModal);
                hv_Line1 = hv_Line1.TupleConcat(hv_FirstLineEndRowModal);
                hv_Line1 = hv_Line1.TupleConcat(hv_FirstLineEndColumnModal);
                hv_Line2 = new HTuple();
                hv_Line2 = hv_Line2.TupleConcat(hv_SecondLineBeginRowModal);
                hv_Line2 = hv_Line2.TupleConcat(hv_SecondLineBeginColumnModal);
                hv_Line2 = hv_Line2.TupleConcat(hv_SecondLineEndRowModal);
                hv_Line2 = hv_Line2.TupleConcat(hv_SecondLineEndColumnModal);
                HOperatorSet.AddMetrologyObjectGeneric(hv_MetrologyHandle, "line", hv_Line1.TupleConcat(hv_Line2), 20, 10, 1, 1, new HTuple(), new HTuple(), out hv_MetrologyLine);

                //获取测量模型里的模型轮廓
                HObject ho_ModelContour;
                HOperatorSet.GenEmptyObj(out ho_ModelContour);
                ho_ModelContour.Dispose();
                HOperatorSet.GetMetrologyObjectModelContour(out ho_ModelContour, hv_MetrologyHandle, "all", 1.5);

                //获取测量模型里的测量区域
                HObject ho_MeasureContour;
                HOperatorSet.GenEmptyObj(out ho_MeasureContour);
                ho_MeasureContour.Dispose();

                HTuple hv_Row = null, hv_Column = null;
                HOperatorSet.GetMetrologyObjectMeasures(out ho_MeasureContour, hv_MetrologyHandle, "all", "all", out hv_Row, out hv_Column);


                //显示图像及轮廓
                HOperatorSet.DispObj(ho_Image, GraphInteractiveObect.halconWindow.HalconWindow);
                HOperatorSet.DispObj(ho_ModelContour, GraphInteractiveObect.halconWindow.HalconWindow);
                HOperatorSet.DispObj(ho_MeasureContour, GraphInteractiveObect.halconWindow.HalconWindow);

                //* 设置测量对象的参考坐标系原点在模板坐标位置
                HTuple hv_TempleteRow = null, hv_TempleteColumn = null, hv_TempleteAngle = null;
                //hv_TempleteRow = double.Parse(this.ModelRow_textBox.Text);
                //hv_TempleteColumn = double.Parse(this.ModelColumn_textBox.Text);
                //hv_TempleteAngle = double.Parse(this.ModelAngle_textBox.Text);
                hv_TempleteRow = double.Parse(this.txtRow.Text);
                hv_TempleteColumn = double.Parse(this.txtCol.Text);
                hv_TempleteAngle = double.Parse(this.txtAngle.Text);

                HOperatorSet.SetMetrologyModelParam(hv_MetrologyHandle, "reference_system", ((hv_TempleteRow.TupleConcat(hv_TempleteColumn))).TupleConcat(hv_TempleteAngle));

                HOperatorSet.WriteMetrologyModel(hv_MetrologyHandle, Directory.GetCurrentDirectory() + @"/MetrologyHandle.mtr");

            }
            catch (HalconException hex)
            {
                MessageBox.Show(hex.GetErrorMessage(), "HALCON error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Windows error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OfflineMeasureTest(object sender, EventArgs e)
        {
            try
            {

                HTuple hv_TempleteRow = null;
                HTuple hv_TempleteColumn = null;
                HTuple hv_TempleteAngle = null;

                //hv_TempleteRow = double.Parse(this.ModelRow_textBox.Text);
                //hv_TempleteColumn = double.Parse(this.ModelColumn_textBox.Text);
                //hv_TempleteAngle = double.Parse(this.ModelAngle_textBox.Text);

                hv_TempleteRow = double.Parse(this.txtRow.Text);
                hv_TempleteColumn = double.Parse(this.txtCol.Text);
                hv_TempleteAngle = double.Parse(this.txtAngle.Text);

                if (File.Exists(Directory.GetCurrentDirectory() + @"/MetrologyHandle.mtr"))
                {
                    HOperatorSet.ReadMetrologyModel(Directory.GetCurrentDirectory() + @"/MetrologyHandle.mtr", out hv_MetrologyHandle);
                }
                else
                {
                    MessageBox.Show("请先建模");
                    return;
                }


                HObject ho_MeasureRegion;
                HOperatorSet.GenEmptyObj(out ho_MeasureRegion);

                HTuple Distance = null;
                string Result = MeasureAlgorithm(ho_Image, double.Parse(this.txtLow.Text), double.Parse(this.txtUpper.Text), hv_MetrologyHandle, hv_TempleteRow, hv_TempleteColumn, hv_TempleteAngle, out Distance, out ho_MeasureRegion);

                HOperatorSet.SetColor(GraphInteractiveObect.halconWindow.HalconWindow, "red");
                HOperatorSet.SetDraw(GraphInteractiveObect.halconWindow.HalconWindow, "margin");
                HOperatorSet.DispObj(ho_Image, GraphInteractiveObect.halconWindow.HalconWindow);
                HOperatorSet.DispObj(ho_MeasureRegion, GraphInteractiveObect.halconWindow.HalconWindow);

                saveImage("Pos"+ Result);

                if (Result == "PASS")
                {
                    this.DisplayResult_label.Text = "合格";
                    this.DisplayResult_label.ForeColor = Color.Green;
                    this.Distance_textBox.Text = Distance.ToString();
                    this.Distance_textBox2.Text = Distance.ToString();
                    this.Distance_label.Text = Distance.ToString();
                }
                if (Result == "NG")
                {
                    this.DisplayResult_label.Text = "不合格";
                    this.DisplayResult_label.ForeColor = Color.Red;
                    this.Distance_textBox.Text = Distance.ToString();
                    this.Distance_textBox2.Text = Distance.ToString();
                    this.Distance_label.Text = Distance.ToString();
                }

                ho_MeasureRegion.Dispose();

            }
            catch (HalconException ex)
            {
                MessageBox.Show(ex.GetErrorMessage(), "参数异常", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void StartTest(object sender, EventArgs e)
        {

            if (this.StartTest_button.Text == "Start")
            {
#if (NormalTest)
                ushort axis     =0;
                double start    =1000;
                double speed    =4000;
                double stop     =2000;
                double acc      =10000;
                double dec      =10000;
                ushort Direct   =0;
                MotionObject.ContinuationMove(axis, start, speed, stop, acc, dec,Direct);
#endif
                this.StartTest_button.Text = "Stop";
                this.StartTest_button.ForeColor = Color.White;
                this.StartTest_button.BackColor = Color.Blue;

                AcquireImageStop = false;
                if (AcquireImage.ThreadState == System.Threading.ThreadState.Unstarted)
                {
                    AcquireImage.IsBackground = true;
                    AcquireImage.Priority = ThreadPriority.Normal;
                    AcquireImage.Start();

                }

                if ((AcquireImage.ThreadState == System.Threading.ThreadState.Stopped) || (AcquireImage.ThreadState == System.Threading.ThreadState.Aborted))
                {
                    AcquireImage = new Thread(new ThreadStart(AcquireImageFunction));
                    AcquireImage.IsBackground = true;
                    AcquireImage.Priority = ThreadPriority.Normal;
                    AcquireImage.Start();
                }
                string strLogToScreen = "开始采集图像\n";
                UpdateLogMessage(strLogToScreen);
                //CounterTMT.AppEvents.Instance.OnUpdateScreenRun(strLogToScreen);
            }
            else if (this.StartTest_button.Text == "Stop")
            {
#if (NormalTest)
                    ushort axis     =0;
                    MotionObject.ImmediatelyStop(axis);
#endif

                this.StartTest_button.Text = "Start";
                this.StartTest_button.ForeColor = Color.White;
                this.StartTest_button.BackColor = Color.Blue;

                AcquireImageStop = true;
                string strLogToScreen = "停止采集图像\n";
                UpdateLogMessage(strLogToScreen);
                //CounterTMT.AppEvents.Instance.OnUpdateScreenRun(strLogToScreen);

            }

        }
        private void ExitApp(object sender, EventArgs e)
        {
            if (this.StartTest_button.Text == "Start")
                StartTest(null, null);
            Thread.Sleep(2000);
            IO_ThreadStop = false;
            AcquireImageStop = false;
            Thread.Sleep(2000);


            HOperatorSet.CloseFramegrabber(hv_AcqHandle);//关闭相机

            ho_Image.Dispose();//释放对象

            IO_Thread.Abort();
            AcquireImage.Abort();

            HOperatorSet.ClearMetrologyModel(hv_MetrologyHandle);
            HOperatorSet.ClearShapeModel(hv_ModelID);

#if (NormalTest)
                MotionObject.CloseMotionCard();
#endif
            System.Environment.Exit(0);
        }
        private void UpdateLogMessage(string Content)
        {
            string TotalLogContent = DateTime.Now.ToString("yyyy年MM月dd日HH时mm分ss秒   ") + Content;
            //this.DisplayLog_textBox.AppendText(TotalLogContent);
            CounterTMT.AppEvents.Instance.OnUpdateScreenRun(TotalLogContent);

        }

        /// <summary>
        /// 图像校正
        /// </summary>
        /// <param name="UncorrectedImage"></param>
        /// <returns></returns>
        private HObject CalibrationImage(HObject UncorrectedImage)
        {

            HTuple hv_CamParam = null, hv_PoseCalib = null, hv_PoseCalibRot = null, hv_Pose = null, hv_PixelDist = null, hv_HomMat3D = null;
            HObject ho_Map, ho_ModelImageMapped;
            HOperatorSet.GenEmptyObj(out ho_Map);
            HOperatorSet.GenEmptyObj(out ho_ModelImageMapped);

            //摄像机内参
            HOperatorSet.ReadCamPar(CameraInnerParameterFile, out hv_CamParam);

            //摄像机外参(摄像机位姿)
            HOperatorSet.ReadPose(CameraOuterParameterFile, out hv_PoseCalib);


            //将位姿绕Z轴逆时针旋转180度
            HOperatorSet.TupleReplace(hv_PoseCalib, 5, (hv_PoseCalib.TupleSelect(5)) - 180, out hv_PoseCalibRot);


            //调整位姿,X轴向左移动0.04，Y轴向上移动0.03，Z轴向标定板移动0.006
            //HOperatorSet.SetOriginPose(hv_PoseCalibRot,
            //    double.Parse(this.OffsetX_textBox.Text),
            //    double.Parse(this.OffsetY_textBox.Text),
            //    double.Parse(this.OffsetZ_textBox.Text), out hv_Pose);

            HOperatorSet.SetOriginPose(hv_PoseCalibRot,
                                         double.Parse(this.txtX.Text),
                                         double.Parse(this.txtY.Text),
                                         double.Parse(this.txtZ.Text), out hv_Pose);

            //像素当量
            //hv_PixelDist = double.Parse(this.PixelDangLiang_textBox.Text);

            hv_PixelDist = double.Parse(this.txtP.Text);


            //将3D位姿转换为齐次变换矩阵。
            HOperatorSet.PoseToHomMat3d(hv_Pose, out hv_HomMat3D);


            //生成图像平面与世界坐标系平面z = 0之间映射的投影图。
            HOperatorSet.GenImageToWorldPlaneMap(out ho_Map, hv_CamParam, hv_Pose, ImageWidth, ImageHeight, ImageWidth, ImageHeight, hv_PixelDist, "bilinear");


            //通过映射关系,对图像进行校正
            HOperatorSet.MapImage(UncorrectedImage, ho_Map, out ho_ModelImageMapped);


            return ho_ModelImageMapped;

        }
        private void Halcon_me_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ExitApp_button.PerformClick();
        }
        private void LoadInnerCameraParameter(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\ini\";
            if (!Directory.Exists(path) || !File.Exists(path + @"caltab.ps"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
                ofd.ValidateNames = true;
                ofd.CheckPathExists = true;
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CameraInnerParameterFile = ofd.FileName;
                    this.CameraInnerParameterFile_label.Text = CameraInnerParameterFile;
                }
            }
            else
            {
                CameraInnerParameterFile = path + @"inner.cal";
                this.CameraInnerParameterFile_label.Text = CameraInnerParameterFile;
            }
        }

        private void LoadOuterCameraParameter(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\ini\";
            if (!Directory.Exists(path) || !File.Exists(path + @"caltab.ps"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Excel文件(*.xls;*.xlsx)|*.xls;*.xlsx|所有文件|*.*";
                ofd.ValidateNames = true;
                ofd.CheckPathExists = true;
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CameraOuterParameterFile = ofd.FileName;
                    this.CameraOuterParameterFile_label.Text = CameraOuterParameterFile;
                }
            }
            else
            {
                CameraOuterParameterFile = path + @"outter.dat";
                this.CameraOuterParameterFile_label.Text = CameraOuterParameterFile;
            }
        }

        private void BtnFun2_Click(object sender, EventArgs e)
        {
            ProductSignal = 1;
        }

        private void CalirationImage_checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OfflineLocation(object sender, EventArgs e)
        {
            SearchObject(hv_ModelID, ho_Image);
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveImage_Click(object sender, EventArgs e)
        {

            saveImage("Now");
        }
        private void saveImage(string ImageType)
        {
            try
            {
                //HOperatorSet.SetWindowExtents(m_WindowHandle2, 0, 0, m_imgWidth, m_imgHeight);
                //HOperatorSet.SetPart(m_WindowHandle2, 0, 0, m_imgHeight - 1, m_imgWidth - 1);
                //set_display_font(m_WindowHandle2, 20, "mono", "true", "false");
                //HOperatorSet.DispObj(m_Image, m_WindowHandle2);
                //HOperatorSet.disp_message(m_WindowHandle2, "2018-08-31 20:30:45", "window", 12, 12, "green", "false");
                //HOperatorSet.DumpWindow(GraphInteractiveObect.halconWindow.HalconWindow, "jpg", Directory.GetCurrentDirectory() + @"\" + DateTime.Now.ToString("yyyyMMddHHmmssff") + ".jpg");

                HObject Image = null;
                // SveFilNew.OverwritePrompt = true;
                HOperatorSet.DumpWindowImage(out Image, GraphInteractiveObect.halconWindow.HalconWindow);
                string folderpath = Directory.GetCurrentDirectory() + @"\"+ ImageType + @"\";
                if (!Directory.Exists(folderpath))
                {
                    Directory.CreateDirectory(folderpath);
                }
                string filepath = folderpath + @"\" + DateTime.Now.ToString("yyyyMMddHHmmssff") + ".jpg";
                HOperatorSet.WriteImage(Image, "jpg", 0, folderpath);
            }
            catch (HalconException HDevExpDefaultException)
            {
                throw HDevExpDefaultException;
            }
        }
    }
}