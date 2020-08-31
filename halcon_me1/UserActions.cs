using System;
using System.Collections.Generic;
using HalconDotNet;
using System.Windows.Forms;


namespace halcon_me1
{
  /// <summary>
  /// This is the place where the user adds his/her code called from the draw
  /// object callbacks.
  /// </summary>
  class UserActions
  {
      private GraphInteractive halcon_dialog;

      public UserActions(GraphInteractive hd)
    {
      halcon_dialog = hd;
    }

    public void SobelFilter(HDrawingObject dobj, HWindow hwin,string type)
    {
      try
      {
        /*
        HImage image = (HImage)halcon_dialog.BackgroundImage;
        HRegion region = new HRegion(dobj.GetDrawingObjectIconic());
        halcon_dialog.AddToStack(image.ReduceDomain(region).SobelAmp("sum_abs", 11));
        halcon_dialog.DisplayResults();
        */
      }
      catch (HalconException hex)
      {
        MessageBox.Show(hex.GetErrorMessage(), "HALCON error", MessageBoxButtons.OK);
      }
    }
  }
}
