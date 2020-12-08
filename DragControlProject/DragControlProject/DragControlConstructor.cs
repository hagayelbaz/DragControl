using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragControlNamespace
{
    public sealed partial class DragControl
    {
        //Constructor

        // Enter the "owner" of the window normally 'this' and the control you want to allow dragging,
        public DragControl(Form Owner, Control controlToDrag)
        {
            this.control_to_drag = controlToDrag;
            this.point = control_to_drag.Location;
            this.Owner = Owner;
            this.mycontrols = new MyControls(this.Owner, this.control_to_drag);
            this.control_to_drag.DragAble(this.alowdrag);
        }
        // Enter the "owner" of the window normally 'this' and the control you want to allow dragging,
        //  ' Except ' Used for controls you do not want to include in the ban     
        public DragControl(Form Owner, Control controlToDrag, params Control[] Except)
        {
            this.control_to_drag = controlToDrag;
            this.point = control_to_drag.Location;
            this.Owner = Owner;
            this.mycontrols = new MyControls(this.Owner, this.control_to_drag, Except);
            this.control_to_drag.DragAble(this.alowdrag);
        }
        //Add Type of button you want to allow to pass
        public DragControl(Form Owner, Control controlToDrag, params Type[] exceptType)
        {
            this.control_to_drag = controlToDrag;
            this.point = control_to_drag.Location;
            this.Owner = Owner;
            this.mycontrols = new MyControls(this.Owner, this.control_to_drag, exceptType);
            this.control_to_drag.DragAble(this.alowdrag);
        }
    }
}
