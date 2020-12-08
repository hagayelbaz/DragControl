using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragControlNamespace
{
    public sealed partial class DragControl
    {
        //save last control location for 'MoveToLastlocation' function
        private Point point;
        private Control control_to_drag;
        private Form Owner;
        private bool alowdrag = true;
        private MyControls mycontrols;

        public bool AllowDrag
        {
            get => this.alowdrag;
            set
            {
                this.alowdrag = value;
                this.control_to_drag.DragAble(value);
            }
        }
        public string GetStopControlName { get => mycontrols.getStopedControlName; }

        public delegate void EndEventHandled(object sender, EventArgs e);
        public event EndEventHandled Finished;
        public delegate void FreeEventHandled(object sender, EventArgs e);
        public event FreeEventHandled Free;
    }
}
