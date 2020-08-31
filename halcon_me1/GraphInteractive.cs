using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using HalconDotNet;

namespace halcon_me1
{
    
    
    public interface IHWindowGraphicStack
    {
        void DisplayResults();
        void AddToStack(HObject o);
    }

    public partial class GraphInteractive : Form, IHWindowGraphicStack
    {
        private List<HDrawingObject> drawing_objects = new List<HDrawingObject>();
        private UserActions user_actions;
        private Stack<HObject> graphic_stack = new Stack<HObject>();
        private HDrawingObject selected_drawing_object = new HDrawingObject(250, 250, 100);
        private HImage background_image = null;
        private object stack_lock = new object();
        public  HalconDotNet.HWindowControl halconWindow;

        public void InitHalconDialog(HTuple width, HTuple height)
        {
            halconWindow.HalconWindow.SetPart(0, 0, height.I - 1, width.I - 1);
            user_actions = new UserActions(this);


        }

        public HImage BackgroundImage { get { return background_image; } }

        public void DisplayResults()
        {
            try
            {
                halconWindow.BeginInvoke((MethodInvoker)delegate() { DisplayGraphicStack(); });
            }
            catch (HalconException hex)
            {
                MessageBox.Show(hex.GetErrorMessage(), "HALCON error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HALCON error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnSelectDrawingObject(HDrawingObject dobj, HWindow hwin, string type)
        {
            selected_drawing_object = dobj;
            user_actions.SobelFilter(dobj, hwin, type);
        }

        public void AttachDrawObj(HDrawingObject obj)
        {
            drawing_objects.Add(obj);
            // The HALCON/C# interface offers convenience methods that
            // encapsulate the set_drawing_object_callback operator.
            obj.OnDrag(user_actions.SobelFilter);
            obj.OnAttach(user_actions.SobelFilter);
            obj.OnResize(user_actions.SobelFilter);
            obj.OnSelect(OnSelectDrawingObject);
            obj.OnAttach(user_actions.SobelFilter);
            //if (selected_drawing_object == null)
                selected_drawing_object = obj;
            halconWindow.HalconWindow.AttachDrawingObjectToWindow(obj);
        }

        public void AddToStack(HObject obj)
        {
            lock (stack_lock)
            {
                graphic_stack.Push(obj);
            }
        }

        private void DisplayGraphicStack()
        {
            lock (stack_lock)
            {
                HOperatorSet.SetSystem("flush_graphic", "false");
                halconWindow.HalconWindow.ClearWindow();
                while (graphic_stack.Count > 0)
                {
                    halconWindow.HalconWindow.DispObj(graphic_stack.Pop());
                }
                HOperatorSet.SetSystem("flush_graphic", "true");
            }
            //halconWindow.HalconWindow.DispCross(50.0, 50.0, 3.0, 0.0);
        }


        public void DeleteRoi()
        {
            long SelectID = 0;
            long ID = 0;
            lock (stack_lock)
            {
                foreach (HDrawingObject dobj in drawing_objects)
                {
                    ID = dobj.ID;
                    SelectID = selected_drawing_object.ID;

                    //if (ID == SelectID)
                    {
                        dobj.Dispose();
                    }
                }

            }

        }


        public void graphic_stackClear()
        {
            lock (stack_lock)
            {
                foreach (HDrawingObject dobj in drawing_objects)
                {
                    dobj.Dispose();
                }

            }

            
            lock (stack_lock)
            {

                drawing_objects.Clear();
                graphic_stack.Clear();
            }
            DisplayGraphicStack();

        }

    }
}
