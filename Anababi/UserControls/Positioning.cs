using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anababi.UserControls
{
    public static class Positioning
    {
        public static void CenterHorizontally(this Control c)
        {
            //Create a rectangle object representing the Parent of this control.
            Rectangle parentRect = c.Parent.ClientRectangle;
            //Center this control horizontally using the Parent's position as a Reference.
            c.Left = (parentRect.Width - c.Width) / 2;
        }
        public static void CenterVertically(this Control c)
        {
            //Create a rectangle object representing the Parent of this control.
            Rectangle parentRect = c.Parent.ClientRectangle;
            //Center this control vertically using the Parent's position as a Reference.
            c.Top = (parentRect.Height - c.Height) / 2;
        }
    }
}
