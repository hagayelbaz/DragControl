using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DragControlNamespace
{
    static class Drag
    {
        // TKey is control to drag, TValue is a flag used while dragging
        private static Dictionary<Control, bool> dragables = new Dictionary<Control, bool>();
        private static Size mouseOffset;

        // Enabling/disabling dragging for control
        public static void DragAble(this Control control, bool enable)
        {
            if (enable)
            {
                if (dragables.ContainsKey(control)) // return if control is already draggable
                    return;
                dragables.Add(control, false);
                // assign required event handlersnnn
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                control.MouseUp += new MouseEventHandler(control_MouseUp);
                control.MouseMove += new MouseEventHandler(control_MouseMove);
            }
            else
            {
                if (!dragables.ContainsKey(control))// return if control is not draggable
                    return;
                // remove event handlers
                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                dragables.Remove(control);
            }
        }
        // turning on dragging
        private static void control_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new Size(e.Location);
            dragables[(Control)sender] = true;
        }
        // turning off dragging
        private static void control_MouseUp(object sender, MouseEventArgs e)
        {          
            dragables[(Control)sender] = false;
        }
        private static void control_MouseMove(object sender, MouseEventArgs e)
        {
            // only if dragging is turned on
            if (dragables[(Control)sender] == true)
            {
                // calculations of control's new position
                Point newLocationOffset = e.Location - mouseOffset;
                ((Control)sender).Left += newLocationOffset.X;
                ((Control)sender).Top += newLocationOffset.Y;
            }
        }
    }
}