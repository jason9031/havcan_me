namespace halcon_me1
{
    partial class halcon_me
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(halcon_me));
            this.btnRead = new System.Windows.Forms.Button();
            this.StartTest_button = new System.Windows.Forms.Button();
            this.btnFun2 = new System.Windows.Forms.Button();
            this.btnFun1 = new System.Windows.Forms.Button();
            this.ExitApp_button = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VideoWindow_hWindowControl = new HalconDotNet.HWindowControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CalirationImage_checkBox = new System.Windows.Forms.CheckBox();
            this.PixelDangLiang_label = new System.Windows.Forms.Label();
            this.PixelDangLiang_textBox = new System.Windows.Forms.TextBox();
            this.OffsetZ_label = new System.Windows.Forms.Label();
            this.OffsetZ_textBox = new System.Windows.Forms.TextBox();
            this.OffsetY_label = new System.Windows.Forms.Label();
            this.OffsetY_textBox = new System.Windows.Forms.TextBox();
            this.OffsetX_label = new System.Windows.Forms.Label();
            this.OffsetX_textBox = new System.Windows.Forms.TextBox();
            this.CameraOuterParameterFile_label = new System.Windows.Forms.Label();
            this.LoadOuterCameraParameter_button = new System.Windows.Forms.Button();
            this.CameraInnerParameterFile_label = new System.Windows.Forms.Label();
            this.LoadInnerCameraParameter_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ModelAngle_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelColumn_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ModelRow_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductLocation_checkBox = new System.Windows.Forms.CheckBox();
            this.OfflineLocation_button = new System.Windows.Forms.Button();
            this.CreateTemplete_button = new System.Windows.Forms.Button();
            this.DrawRectangle_button = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Distance_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MeasuretextTop_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MeasuretextDown_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OfflineMeasureTest_button = new System.Windows.Forms.Button();
            this.DrawMeasureModel_button = new System.Windows.Forms.Button();
            this.DrawStopLine_button = new System.Windows.Forms.Button();
            this.DrawStartLine_button = new System.Windows.Forms.Button();
            this.DisplayResult_label = new System.Windows.Forms.Label();
            this.Distance_label = new System.Windows.Forms.Label();
            this.lblValue2 = new System.Windows.Forms.Label();
            this.lblValue4 = new System.Windows.Forms.Label();
            this.lblValue3 = new System.Windows.Forms.Label();
            this.CalirationImage_checkBox1 = new System.Windows.Forms.CheckBox();
            this.Distance_textBox2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DisplayLog_textBox = new System.Windows.Forms.TextBox();
            this.chkTest = new System.Windows.Forms.CheckBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.btnPosSearch = new System.Windows.Forms.Button();
            this.btnMatchCreate = new System.Windows.Forms.Button();
            this.btnSelectBasicModel = new System.Windows.Forms.Button();
            this.btnTestSize = new System.Windows.Forms.Button();
            this.btnSizeModelCreate = new System.Windows.Forms.Button();
            this.btnEndLine = new System.Windows.Forms.Button();
            this.btnStartLine = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRead.Location = new System.Drawing.Point(914, 475);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read Image";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // StartTest_button
            // 
            this.StartTest_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTest_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartTest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTest_button.Location = new System.Drawing.Point(907, 46);
            this.StartTest_button.Name = "StartTest_button";
            this.StartTest_button.Size = new System.Drawing.Size(99, 47);
            this.StartTest_button.TabIndex = 1;
            this.StartTest_button.Text = "Start";
            this.StartTest_button.UseVisualStyleBackColor = false;
            this.StartTest_button.Click += new System.EventHandler(this.StartTest);
            // 
            // btnFun2
            // 
            this.btnFun2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFun2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFun2.Location = new System.Drawing.Point(907, 151);
            this.btnFun2.Name = "btnFun2";
            this.btnFun2.Size = new System.Drawing.Size(99, 46);
            this.btnFun2.TabIndex = 3;
            this.btnFun2.Text = "Pos OK";
            this.btnFun2.UseVisualStyleBackColor = false;
            this.btnFun2.Click += new System.EventHandler(this.BtnFun2_Click);
            // 
            // btnFun1
            // 
            this.btnFun1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFun1.Location = new System.Drawing.Point(904, 354);
            this.btnFun1.Name = "btnFun1";
            this.btnFun1.Size = new System.Drawing.Size(99, 23);
            this.btnFun1.TabIndex = 2;
            this.btnFun1.Text = "Function1";
            this.btnFun1.UseVisualStyleBackColor = true;
            this.btnFun1.Click += new System.EventHandler(this.BtnFun1_Click);
            // 
            // ExitApp_button
            // 
            this.ExitApp_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitApp_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitApp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitApp_button.Location = new System.Drawing.Point(907, 99);
            this.ExitApp_button.Name = "ExitApp_button";
            this.ExitApp_button.Size = new System.Drawing.Size(99, 46);
            this.ExitApp_button.TabIndex = 5;
            this.ExitApp_button.Text = "Exit";
            this.ExitApp_button.UseVisualStyleBackColor = false;
            this.ExitApp_button.Click += new System.EventHandler(this.ExitApp);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Location = new System.Drawing.Point(914, 510);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 4;
            this.btnSaveImage.Text = "SaveImage";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.BtnSaveImage_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 520);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.VideoWindow_hWindowControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主界面";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // VideoWindow_hWindowControl
            // 
            this.VideoWindow_hWindowControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VideoWindow_hWindowControl.BackColor = System.Drawing.Color.Black;
            this.VideoWindow_hWindowControl.BorderColor = System.Drawing.Color.Black;
            this.VideoWindow_hWindowControl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.VideoWindow_hWindowControl.Location = new System.Drawing.Point(7, 7);
            this.VideoWindow_hWindowControl.Name = "VideoWindow_hWindowControl";
            this.VideoWindow_hWindowControl.Size = new System.Drawing.Size(640, 480);
            this.VideoWindow_hWindowControl.TabIndex = 0;
            this.VideoWindow_hWindowControl.WindowSize = new System.Drawing.Size(640, 480);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CalirationImage_checkBox);
            this.tabPage2.Controls.Add(this.PixelDangLiang_label);
            this.tabPage2.Controls.Add(this.PixelDangLiang_textBox);
            this.tabPage2.Controls.Add(this.OffsetZ_label);
            this.tabPage2.Controls.Add(this.OffsetZ_textBox);
            this.tabPage2.Controls.Add(this.OffsetY_label);
            this.tabPage2.Controls.Add(this.OffsetY_textBox);
            this.tabPage2.Controls.Add(this.OffsetX_label);
            this.tabPage2.Controls.Add(this.OffsetX_textBox);
            this.tabPage2.Controls.Add(this.CameraOuterParameterFile_label);
            this.tabPage2.Controls.Add(this.LoadOuterCameraParameter_button);
            this.tabPage2.Controls.Add(this.CameraInnerParameterFile_label);
            this.tabPage2.Controls.Add(this.LoadInnerCameraParameter_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "图像标定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CalirationImage_checkBox
            // 
            this.CalirationImage_checkBox.AutoSize = true;
            this.CalirationImage_checkBox.Location = new System.Drawing.Point(60, 30);
            this.CalirationImage_checkBox.Name = "CalirationImage_checkBox";
            this.CalirationImage_checkBox.Size = new System.Drawing.Size(98, 17);
            this.CalirationImage_checkBox.TabIndex = 30;
            this.CalirationImage_checkBox.Text = "图像标定使能";
            this.CalirationImage_checkBox.UseVisualStyleBackColor = true;
            // 
            // PixelDangLiang_label
            // 
            this.PixelDangLiang_label.AutoSize = true;
            this.PixelDangLiang_label.Location = new System.Drawing.Point(64, 371);
            this.PixelDangLiang_label.Name = "PixelDangLiang_label";
            this.PixelDangLiang_label.Size = new System.Drawing.Size(55, 13);
            this.PixelDangLiang_label.TabIndex = 29;
            this.PixelDangLiang_label.Text = "像素当量";
            // 
            // PixelDangLiang_textBox
            // 
            this.PixelDangLiang_textBox.Location = new System.Drawing.Point(126, 368);
            this.PixelDangLiang_textBox.Name = "PixelDangLiang_textBox";
            this.PixelDangLiang_textBox.Size = new System.Drawing.Size(100, 20);
            this.PixelDangLiang_textBox.TabIndex = 28;
            this.PixelDangLiang_textBox.Text = "0.0000502793";
            // 
            // OffsetZ_label
            // 
            this.OffsetZ_label.AutoSize = true;
            this.OffsetZ_label.Location = new System.Drawing.Point(64, 325);
            this.OffsetZ_label.Name = "OffsetZ_label";
            this.OffsetZ_label.Size = new System.Drawing.Size(50, 13);
            this.OffsetZ_label.TabIndex = 27;
            this.OffsetZ_label.Text = "Z偏移量";
            // 
            // OffsetZ_textBox
            // 
            this.OffsetZ_textBox.Location = new System.Drawing.Point(126, 322);
            this.OffsetZ_textBox.Name = "OffsetZ_textBox";
            this.OffsetZ_textBox.Size = new System.Drawing.Size(100, 20);
            this.OffsetZ_textBox.TabIndex = 26;
            this.OffsetZ_textBox.Tag = "";
            this.OffsetZ_textBox.Text = "0.001";
            // 
            // OffsetY_label
            // 
            this.OffsetY_label.AutoSize = true;
            this.OffsetY_label.Location = new System.Drawing.Point(64, 280);
            this.OffsetY_label.Name = "OffsetY_label";
            this.OffsetY_label.Size = new System.Drawing.Size(50, 13);
            this.OffsetY_label.TabIndex = 25;
            this.OffsetY_label.Text = "Y偏移量";
            // 
            // OffsetY_textBox
            // 
            this.OffsetY_textBox.Location = new System.Drawing.Point(126, 277);
            this.OffsetY_textBox.Name = "OffsetY_textBox";
            this.OffsetY_textBox.Size = new System.Drawing.Size(100, 20);
            this.OffsetY_textBox.TabIndex = 24;
            this.OffsetY_textBox.Text = "0.002";
            // 
            // OffsetX_label
            // 
            this.OffsetX_label.AutoSize = true;
            this.OffsetX_label.Location = new System.Drawing.Point(64, 237);
            this.OffsetX_label.Name = "OffsetX_label";
            this.OffsetX_label.Size = new System.Drawing.Size(50, 13);
            this.OffsetX_label.TabIndex = 23;
            this.OffsetX_label.Text = "X偏移量";
            // 
            // OffsetX_textBox
            // 
            this.OffsetX_textBox.Location = new System.Drawing.Point(126, 233);
            this.OffsetX_textBox.Name = "OffsetX_textBox";
            this.OffsetX_textBox.Size = new System.Drawing.Size(100, 20);
            this.OffsetX_textBox.TabIndex = 22;
            this.OffsetX_textBox.Text = "0.004";
            // 
            // CameraOuterParameterFile_label
            // 
            this.CameraOuterParameterFile_label.Location = new System.Drawing.Point(203, 153);
            this.CameraOuterParameterFile_label.Name = "CameraOuterParameterFile_label";
            this.CameraOuterParameterFile_label.Size = new System.Drawing.Size(328, 40);
            this.CameraOuterParameterFile_label.TabIndex = 21;
            this.CameraOuterParameterFile_label.Text = "摄像机外参文件路径";
            this.CameraOuterParameterFile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadOuterCameraParameter_button
            // 
            this.LoadOuterCameraParameter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoadOuterCameraParameter_button.ForeColor = System.Drawing.Color.White;
            this.LoadOuterCameraParameter_button.Location = new System.Drawing.Point(54, 148);
            this.LoadOuterCameraParameter_button.Name = "LoadOuterCameraParameter_button";
            this.LoadOuterCameraParameter_button.Size = new System.Drawing.Size(145, 52);
            this.LoadOuterCameraParameter_button.TabIndex = 20;
            this.LoadOuterCameraParameter_button.Text = "加载摄像机外参";
            this.LoadOuterCameraParameter_button.UseVisualStyleBackColor = false;
            this.LoadOuterCameraParameter_button.Click += new System.EventHandler(this.LoadOuterCameraParameter);
            // 
            // CameraInnerParameterFile_label
            // 
            this.CameraInnerParameterFile_label.Location = new System.Drawing.Point(203, 74);
            this.CameraInnerParameterFile_label.Name = "CameraInnerParameterFile_label";
            this.CameraInnerParameterFile_label.Size = new System.Drawing.Size(328, 40);
            this.CameraInnerParameterFile_label.TabIndex = 19;
            this.CameraInnerParameterFile_label.Text = "摄像机内参文件路径";
            this.CameraInnerParameterFile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadInnerCameraParameter_button
            // 
            this.LoadInnerCameraParameter_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.LoadInnerCameraParameter_button.ForeColor = System.Drawing.Color.White;
            this.LoadInnerCameraParameter_button.Location = new System.Drawing.Point(54, 69);
            this.LoadInnerCameraParameter_button.Name = "LoadInnerCameraParameter_button";
            this.LoadInnerCameraParameter_button.Size = new System.Drawing.Size(145, 52);
            this.LoadInnerCameraParameter_button.TabIndex = 18;
            this.LoadInnerCameraParameter_button.Text = "加载摄像机内参";
            this.LoadInnerCameraParameter_button.UseVisualStyleBackColor = false;
            this.LoadInnerCameraParameter_button.Click += new System.EventHandler(this.LoadInnerCameraParameter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ModelAngle_textBox);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ModelColumn_textBox);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.ModelRow_textBox);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ProductLocation_checkBox);
            this.tabPage3.Controls.Add(this.OfflineLocation_button);
            this.tabPage3.Controls.Add(this.CreateTemplete_button);
            this.tabPage3.Controls.Add(this.DrawRectangle_button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(652, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "产品定位";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ModelAngle_textBox
            // 
            this.ModelAngle_textBox.Location = new System.Drawing.Point(468, 376);
            this.ModelAngle_textBox.Name = "ModelAngle_textBox";
            this.ModelAngle_textBox.Size = new System.Drawing.Size(56, 20);
            this.ModelAngle_textBox.TabIndex = 34;
            this.ModelAngle_textBox.Text = "-0.000202794392210834";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Angle:";
            // 
            // ModelColumn_textBox
            // 
            this.ModelColumn_textBox.Location = new System.Drawing.Point(324, 376);
            this.ModelColumn_textBox.Name = "ModelColumn_textBox";
            this.ModelColumn_textBox.Size = new System.Drawing.Size(56, 20);
            this.ModelColumn_textBox.TabIndex = 32;
            this.ModelColumn_textBox.Text = "520.477619746856";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Column:";
            // 
            // ModelRow_textBox
            // 
            this.ModelRow_textBox.Location = new System.Drawing.Point(174, 376);
            this.ModelRow_textBox.Name = "ModelRow_textBox";
            this.ModelRow_textBox.Size = new System.Drawing.Size(56, 20);
            this.ModelRow_textBox.TabIndex = 30;
            this.ModelRow_textBox.Text = "85.53084229404";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Row:";
            // 
            // ProductLocation_checkBox
            // 
            this.ProductLocation_checkBox.AutoSize = true;
            this.ProductLocation_checkBox.Location = new System.Drawing.Point(116, 35);
            this.ProductLocation_checkBox.Name = "ProductLocation_checkBox";
            this.ProductLocation_checkBox.Size = new System.Drawing.Size(98, 17);
            this.ProductLocation_checkBox.TabIndex = 28;
            this.ProductLocation_checkBox.Text = "产品定位使能";
            this.ProductLocation_checkBox.UseVisualStyleBackColor = true;
            // 
            // OfflineLocation_button
            // 
            this.OfflineLocation_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.OfflineLocation_button.ForeColor = System.Drawing.Color.White;
            this.OfflineLocation_button.Location = new System.Drawing.Point(246, 268);
            this.OfflineLocation_button.Name = "OfflineLocation_button";
            this.OfflineLocation_button.Size = new System.Drawing.Size(145, 52);
            this.OfflineLocation_button.TabIndex = 27;
            this.OfflineLocation_button.Text = "模拟定位";
            this.OfflineLocation_button.UseVisualStyleBackColor = false;
            this.OfflineLocation_button.Click += new System.EventHandler(this.OfflineLocation);
            // 
            // CreateTemplete_button
            // 
            this.CreateTemplete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CreateTemplete_button.ForeColor = System.Drawing.Color.White;
            this.CreateTemplete_button.Location = new System.Drawing.Point(246, 154);
            this.CreateTemplete_button.Name = "CreateTemplete_button";
            this.CreateTemplete_button.Size = new System.Drawing.Size(145, 52);
            this.CreateTemplete_button.TabIndex = 26;
            this.CreateTemplete_button.Text = "创建模版";
            this.CreateTemplete_button.UseVisualStyleBackColor = false;
            this.CreateTemplete_button.Click += new System.EventHandler(this.CreateTemplete);
            // 
            // DrawRectangle_button
            // 
            this.DrawRectangle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DrawRectangle_button.ForeColor = System.Drawing.Color.White;
            this.DrawRectangle_button.Location = new System.Drawing.Point(246, 56);
            this.DrawRectangle_button.Name = "DrawRectangle_button";
            this.DrawRectangle_button.Size = new System.Drawing.Size(145, 52);
            this.DrawRectangle_button.TabIndex = 25;
            this.DrawRectangle_button.Text = "对象选取";
            this.DrawRectangle_button.UseVisualStyleBackColor = false;
            this.DrawRectangle_button.Click += new System.EventHandler(this.DrawRectangle);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Distance_textBox);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.MeasuretextTop_TextBox);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.MeasuretextDown_TextBox);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.OfflineMeasureTest_button);
            this.tabPage5.Controls.Add(this.DrawMeasureModel_button);
            this.tabPage5.Controls.Add(this.DrawStopLine_button);
            this.tabPage5.Controls.Add(this.DrawStartLine_button);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(652, 494);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "尺寸测量";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Distance_textBox
            // 
            this.Distance_textBox.Location = new System.Drawing.Point(189, 389);
            this.Distance_textBox.Name = "Distance_textBox";
            this.Distance_textBox.Size = new System.Drawing.Size(56, 20);
            this.Distance_textBox.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "距离值:";
            // 
            // MeasuretextTop_TextBox
            // 
            this.MeasuretextTop_TextBox.Location = new System.Drawing.Point(457, 391);
            this.MeasuretextTop_TextBox.Name = "MeasuretextTop_TextBox";
            this.MeasuretextTop_TextBox.Size = new System.Drawing.Size(56, 20);
            this.MeasuretextTop_TextBox.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "测试上限:";
            // 
            // MeasuretextDown_TextBox
            // 
            this.MeasuretextDown_TextBox.Location = new System.Drawing.Point(333, 391);
            this.MeasuretextDown_TextBox.Name = "MeasuretextDown_TextBox";
            this.MeasuretextDown_TextBox.Size = new System.Drawing.Size(56, 20);
            this.MeasuretextDown_TextBox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "测试下限:";
            // 
            // OfflineMeasureTest_button
            // 
            this.OfflineMeasureTest_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.OfflineMeasureTest_button.ForeColor = System.Drawing.Color.White;
            this.OfflineMeasureTest_button.Location = new System.Drawing.Point(251, 304);
            this.OfflineMeasureTest_button.Name = "OfflineMeasureTest_button";
            this.OfflineMeasureTest_button.Size = new System.Drawing.Size(145, 52);
            this.OfflineMeasureTest_button.TabIndex = 32;
            this.OfflineMeasureTest_button.Text = "4.模拟测试";
            this.OfflineMeasureTest_button.UseVisualStyleBackColor = false;
            this.OfflineMeasureTest_button.Click += new System.EventHandler(this.OfflineMeasureTest);
            // 
            // DrawMeasureModel_button
            // 
            this.DrawMeasureModel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DrawMeasureModel_button.ForeColor = System.Drawing.Color.White;
            this.DrawMeasureModel_button.Location = new System.Drawing.Point(251, 217);
            this.DrawMeasureModel_button.Name = "DrawMeasureModel_button";
            this.DrawMeasureModel_button.Size = new System.Drawing.Size(145, 52);
            this.DrawMeasureModel_button.TabIndex = 31;
            this.DrawMeasureModel_button.Text = "3.创建测试模型";
            this.DrawMeasureModel_button.UseVisualStyleBackColor = false;
            this.DrawMeasureModel_button.Click += new System.EventHandler(this.DrawMeasureModel);
            // 
            // DrawStopLine_button
            // 
            this.DrawStopLine_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DrawStopLine_button.ForeColor = System.Drawing.Color.White;
            this.DrawStopLine_button.Location = new System.Drawing.Point(251, 119);
            this.DrawStopLine_button.Name = "DrawStopLine_button";
            this.DrawStopLine_button.Size = new System.Drawing.Size(145, 52);
            this.DrawStopLine_button.TabIndex = 30;
            this.DrawStopLine_button.Text = "2.结束测试直线";
            this.DrawStopLine_button.UseVisualStyleBackColor = false;
            this.DrawStopLine_button.Click += new System.EventHandler(this.DrawStopLine);
            // 
            // DrawStartLine_button
            // 
            this.DrawStartLine_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DrawStartLine_button.ForeColor = System.Drawing.Color.White;
            this.DrawStartLine_button.Location = new System.Drawing.Point(251, 20);
            this.DrawStartLine_button.Name = "DrawStartLine_button";
            this.DrawStartLine_button.Size = new System.Drawing.Size(145, 52);
            this.DrawStartLine_button.TabIndex = 29;
            this.DrawStartLine_button.Text = "1.起始测试直线";
            this.DrawStartLine_button.UseVisualStyleBackColor = false;
            this.DrawStartLine_button.Click += new System.EventHandler(this.DrawStartLine);
            // 
            // DisplayResult_label
            // 
            this.DisplayResult_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayResult_label.AutoSize = true;
            this.DisplayResult_label.Location = new System.Drawing.Point(911, 211);
            this.DisplayResult_label.Name = "DisplayResult_label";
            this.DisplayResult_label.Size = new System.Drawing.Size(37, 13);
            this.DisplayResult_label.TabIndex = 7;
            this.DisplayResult_label.Text = "Result";
            // 
            // Distance_label
            // 
            this.Distance_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Distance_label.AutoSize = true;
            this.Distance_label.Location = new System.Drawing.Point(907, 286);
            this.Distance_label.Name = "Distance_label";
            this.Distance_label.Size = new System.Drawing.Size(49, 13);
            this.Distance_label.TabIndex = 8;
            this.Distance_label.Text = "Distance";
            // 
            // lblValue2
            // 
            this.lblValue2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue2.AutoSize = true;
            this.lblValue2.Location = new System.Drawing.Point(911, 237);
            this.lblValue2.Name = "lblValue2";
            this.lblValue2.Size = new System.Drawing.Size(34, 13);
            this.lblValue2.TabIndex = 9;
            this.lblValue2.Text = "Value";
            // 
            // lblValue4
            // 
            this.lblValue4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue4.AutoSize = true;
            this.lblValue4.Location = new System.Drawing.Point(911, 263);
            this.lblValue4.Name = "lblValue4";
            this.lblValue4.Size = new System.Drawing.Size(34, 13);
            this.lblValue4.TabIndex = 11;
            this.lblValue4.Text = "Value";
            // 
            // lblValue3
            // 
            this.lblValue3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue3.AutoSize = true;
            this.lblValue3.Location = new System.Drawing.Point(911, 250);
            this.lblValue3.Name = "lblValue3";
            this.lblValue3.Size = new System.Drawing.Size(34, 13);
            this.lblValue3.TabIndex = 10;
            this.lblValue3.Text = "Value";
            // 
            // CalirationImage_checkBox1
            // 
            this.CalirationImage_checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CalirationImage_checkBox1.AutoSize = true;
            this.CalirationImage_checkBox1.Location = new System.Drawing.Point(679, 452);
            this.CalirationImage_checkBox1.Name = "CalirationImage_checkBox1";
            this.CalirationImage_checkBox1.Size = new System.Drawing.Size(98, 17);
            this.CalirationImage_checkBox1.TabIndex = 13;
            this.CalirationImage_checkBox1.Text = "CalirationImage";
            this.CalirationImage_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Distance_textBox2
            // 
            this.Distance_textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Distance_textBox2.Location = new System.Drawing.Point(905, 307);
            this.Distance_textBox2.Name = "Distance_textBox2";
            this.Distance_textBox2.Size = new System.Drawing.Size(100, 20);
            this.Distance_textBox2.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(904, 409);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(904, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // DisplayLog_textBox
            // 
            this.DisplayLog_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayLog_textBox.Location = new System.Drawing.Point(13, 646);
            this.DisplayLog_textBox.Multiline = true;
            this.DisplayLog_textBox.Name = "DisplayLog_textBox";
            this.DisplayLog_textBox.Size = new System.Drawing.Size(601, 69);
            this.DisplayLog_textBox.TabIndex = 18;
            // 
            // chkTest
            // 
            this.chkTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTest.AutoSize = true;
            this.chkTest.Checked = true;
            this.chkTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTest.Location = new System.Drawing.Point(679, 479);
            this.chkTest.Name = "chkTest";
            this.chkTest.Size = new System.Drawing.Size(47, 17);
            this.chkTest.TabIndex = 19;
            this.chkTest.Text = "Test";
            this.chkTest.UseVisualStyleBackColor = true;
            // 
            // txtAngle
            // 
            this.txtAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAngle.Location = new System.Drawing.Point(951, 695);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(56, 20);
            this.txtAngle.TabIndex = 40;
            this.txtAngle.Text = "-0.000202794392210834";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(908, 699);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Angle:";
            // 
            // txtCol
            // 
            this.txtCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCol.Location = new System.Drawing.Point(807, 695);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(56, 20);
            this.txtCol.TabIndex = 38;
            this.txtCol.Text = "520.477619746856";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(759, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Column:";
            // 
            // txtRow
            // 
            this.txtRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRow.Location = new System.Drawing.Point(657, 695);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(56, 20);
            this.txtRow.TabIndex = 36;
            this.txtRow.Text = "85.53084229404";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(625, 699);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Row:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(759, 649);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "像素当量";
            // 
            // txtZ
            // 
            this.txtZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZ.Location = new System.Drawing.Point(815, 672);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(86, 20);
            this.txtZ.TabIndex = 47;
            this.txtZ.Text = "0.001";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(759, 675);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Z偏移量";
            // 
            // txtP
            // 
            this.txtP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtP.Location = new System.Drawing.Point(815, 646);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(86, 20);
            this.txtP.TabIndex = 45;
            this.txtP.Tag = "";
            this.txtP.Text = "0.0000502793";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 675);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Y偏移量";
            // 
            // txtY
            // 
            this.txtY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtY.Location = new System.Drawing.Point(676, 672);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(81, 20);
            this.txtY.TabIndex = 43;
            this.txtY.Text = "0.002";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(625, 649);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "X偏移量";
            // 
            // txtX
            // 
            this.txtX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtX.Location = new System.Drawing.Point(676, 646);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(81, 20);
            this.txtX.TabIndex = 41;
            this.txtX.Text = "0.004";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(907, 649);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "下限:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(907, 675);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "上限:";
            // 
            // txtLow
            // 
            this.txtLow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLow.Location = new System.Drawing.Point(952, 646);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(56, 20);
            this.txtLow.TabIndex = 51;
            this.txtLow.Text = "1";
            // 
            // txtUpper
            // 
            this.txtUpper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpper.Location = new System.Drawing.Point(952, 672);
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(56, 20);
            this.txtUpper.TabIndex = 52;
            this.txtUpper.Text = "1000";
            // 
            // btnPosSearch
            // 
            this.btnPosSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPosSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosSearch.ForeColor = System.Drawing.Color.Black;
            this.btnPosSearch.Location = new System.Drawing.Point(679, 174);
            this.btnPosSearch.Name = "btnPosSearch";
            this.btnPosSearch.Size = new System.Drawing.Size(145, 52);
            this.btnPosSearch.TabIndex = 55;
            this.btnPosSearch.Text = "模拟定位";
            this.btnPosSearch.UseVisualStyleBackColor = false;
            this.btnPosSearch.Click += new System.EventHandler(this.OfflineLocation);
            // 
            // btnMatchCreate
            // 
            this.btnMatchCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMatchCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchCreate.ForeColor = System.Drawing.Color.Black;
            this.btnMatchCreate.Location = new System.Drawing.Point(679, 122);
            this.btnMatchCreate.Name = "btnMatchCreate";
            this.btnMatchCreate.Size = new System.Drawing.Size(145, 52);
            this.btnMatchCreate.TabIndex = 54;
            this.btnMatchCreate.Text = "创建模版";
            this.btnMatchCreate.UseVisualStyleBackColor = false;
            this.btnMatchCreate.Click += new System.EventHandler(this.CreateTemplete);
            // 
            // btnSelectBasicModel
            // 
            this.btnSelectBasicModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectBasicModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectBasicModel.ForeColor = System.Drawing.Color.Black;
            this.btnSelectBasicModel.Location = new System.Drawing.Point(679, 70);
            this.btnSelectBasicModel.Name = "btnSelectBasicModel";
            this.btnSelectBasicModel.Size = new System.Drawing.Size(145, 52);
            this.btnSelectBasicModel.TabIndex = 53;
            this.btnSelectBasicModel.Text = "对象选取";
            this.btnSelectBasicModel.UseVisualStyleBackColor = false;
            this.btnSelectBasicModel.CausesValidationChanged += new System.EventHandler(this.DrawRectangle);
            // 
            // btnTestSize
            // 
            this.btnTestSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTestSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestSize.ForeColor = System.Drawing.Color.Black;
            this.btnTestSize.Location = new System.Drawing.Point(679, 382);
            this.btnTestSize.Name = "btnTestSize";
            this.btnTestSize.Size = new System.Drawing.Size(145, 52);
            this.btnTestSize.TabIndex = 59;
            this.btnTestSize.Text = "4.模拟测试";
            this.btnTestSize.UseVisualStyleBackColor = false;
            this.btnTestSize.Click += new System.EventHandler(this.OfflineMeasureTest);
            // 
            // btnSizeModelCreate
            // 
            this.btnSizeModelCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSizeModelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSizeModelCreate.ForeColor = System.Drawing.Color.Black;
            this.btnSizeModelCreate.Location = new System.Drawing.Point(679, 330);
            this.btnSizeModelCreate.Name = "btnSizeModelCreate";
            this.btnSizeModelCreate.Size = new System.Drawing.Size(145, 52);
            this.btnSizeModelCreate.TabIndex = 58;
            this.btnSizeModelCreate.Text = "3.创建测试模型";
            this.btnSizeModelCreate.UseVisualStyleBackColor = false;
            this.btnSizeModelCreate.Click += new System.EventHandler(this.DrawMeasureModel);
            // 
            // btnEndLine
            // 
            this.btnEndLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEndLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndLine.ForeColor = System.Drawing.Color.Black;
            this.btnEndLine.Location = new System.Drawing.Point(679, 278);
            this.btnEndLine.Name = "btnEndLine";
            this.btnEndLine.Size = new System.Drawing.Size(145, 52);
            this.btnEndLine.TabIndex = 57;
            this.btnEndLine.Text = "2.结束测试直线";
            this.btnEndLine.UseVisualStyleBackColor = false;
            this.btnEndLine.Click += new System.EventHandler(this.DrawStopLine);
            // 
            // btnStartLine
            // 
            this.btnStartLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStartLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartLine.ForeColor = System.Drawing.Color.Black;
            this.btnStartLine.Location = new System.Drawing.Point(679, 226);
            this.btnStartLine.Name = "btnStartLine";
            this.btnStartLine.Size = new System.Drawing.Size(145, 52);
            this.btnStartLine.TabIndex = 56;
            this.btnStartLine.Text = "1.起始测试直线";
            this.btnStartLine.UseVisualStyleBackColor = false;
            this.btnStartLine.Click += new System.EventHandler(this.DrawStartLine);
            // 
            // halcon_me
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 721);
            this.Controls.Add(this.btnTestSize);
            this.Controls.Add(this.btnSizeModelCreate);
            this.Controls.Add(this.btnEndLine);
            this.Controls.Add(this.btnStartLine);
            this.Controls.Add(this.btnPosSearch);
            this.Controls.Add(this.btnMatchCreate);
            this.Controls.Add(this.btnSelectBasicModel);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExitApp_button);
            this.Controls.Add(this.btnFun2);
            this.Controls.Add(this.chkTest);
            this.Controls.Add(this.DisplayLog_textBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Distance_textBox2);
            this.Controls.Add(this.CalirationImage_checkBox1);
            this.Controls.Add(this.lblValue4);
            this.Controls.Add(this.lblValue3);
            this.Controls.Add(this.lblValue2);
            this.Controls.Add(this.Distance_label);
            this.Controls.Add(this.DisplayResult_label);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.btnFun1);
            this.Controls.Add(this.StartTest_button);
            this.Controls.Add(this.btnRead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 760);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1024, 760);
            this.Name = "halcon_me";
            this.Text = "halcon_me";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Halcon_me_FormClosed);
            this.Load += new System.EventHandler(this.Halcon_me_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button StartTest_button;
        private System.Windows.Forms.Button btnFun2;
        private System.Windows.Forms.Button btnFun1;
        private System.Windows.Forms.Button ExitApp_button;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private HalconDotNet.HWindowControl VideoWindow_hWindowControl;
        private System.Windows.Forms.Label DisplayResult_label;
        private System.Windows.Forms.Label Distance_label;
        private System.Windows.Forms.Label lblValue2;
        private System.Windows.Forms.Label lblValue4;
        private System.Windows.Forms.Label lblValue3;
        private System.Windows.Forms.CheckBox CalirationImage_checkBox1;
        private System.Windows.Forms.TextBox Distance_textBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox CalirationImage_checkBox;
        private System.Windows.Forms.Label PixelDangLiang_label;
        private System.Windows.Forms.TextBox PixelDangLiang_textBox;
        private System.Windows.Forms.Label OffsetZ_label;
        private System.Windows.Forms.TextBox OffsetZ_textBox;
        private System.Windows.Forms.Label OffsetY_label;
        private System.Windows.Forms.TextBox OffsetY_textBox;
        private System.Windows.Forms.Label OffsetX_label;
        private System.Windows.Forms.TextBox OffsetX_textBox;
        private System.Windows.Forms.Label CameraOuterParameterFile_label;
        private System.Windows.Forms.Button LoadOuterCameraParameter_button;
        private System.Windows.Forms.Label CameraInnerParameterFile_label;
        private System.Windows.Forms.Button LoadInnerCameraParameter_button;
        private System.Windows.Forms.TextBox ModelAngle_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelColumn_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ModelRow_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ProductLocation_checkBox;
        private System.Windows.Forms.Button OfflineLocation_button;
        private System.Windows.Forms.Button CreateTemplete_button;
        private System.Windows.Forms.Button DrawRectangle_button;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox Distance_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MeasuretextTop_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MeasuretextDown_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button OfflineMeasureTest_button;
        private System.Windows.Forms.Button DrawMeasureModel_button;
        private System.Windows.Forms.Button DrawStopLine_button;
        private System.Windows.Forms.Button DrawStartLine_button;
        private System.Windows.Forms.TextBox DisplayLog_textBox;
        private System.Windows.Forms.CheckBox chkTest;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Button btnPosSearch;
        private System.Windows.Forms.Button btnMatchCreate;
        private System.Windows.Forms.Button btnSelectBasicModel;
        private System.Windows.Forms.Button btnTestSize;
        private System.Windows.Forms.Button btnSizeModelCreate;
        private System.Windows.Forms.Button btnEndLine;
        private System.Windows.Forms.Button btnStartLine;
    }
}

