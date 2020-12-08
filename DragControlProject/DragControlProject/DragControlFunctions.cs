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
        // Dragging to the corner => event is 'Free' , else event is 'Finished'
        public void DragToCorner()
        {
            this.control_to_drag.LocationChanged -= new EventHandler(Control_Location_Changed_Include_Control);
            this.control_to_drag.LocationChanged -= new EventHandler(Control_Location_Changed_Include_Control_And_Limit);

            this.control_to_drag.LocationChanged += new EventHandler(Control_Location_Changed_Without_Controls);
        }
        //Dragging to the control => event is 'Free' , else event is 'Finished'
        public void DragWithoutDragOnControls()
        {
            this.control_to_drag.LocationChanged -= new EventHandler(Control_Location_Changed_Without_Controls);
            this.control_to_drag.LocationChanged -= new EventHandler(Control_Location_Changed_Include_Control_And_Limit);

            this.control_to_drag.LocationChanged += new EventHandler(Control_Location_Changed_Include_Control);
        }
        // Dragging to the corner & control => event is 'Free' , else event is 'Finished'
        public void DragToCornersWithoutDragOnControls()
        {
            this.control_to_drag.LocationChanged -= new EventHandler(Control_Location_Changed_Without_Controls);
            this.control_to_drag.LocationChanged -= new EventHandler(Control_Location_Changed_Include_Control);

            this.control_to_drag.LocationChanged += new EventHandler(Control_Location_Changed_Include_Control_And_Limit);
        }
        //check if there is control in specific location
        public bool IsLocationFree(Point p)
        {
            List<Control> listcontrols = mycontrols.GetAllControl;
            foreach (Control ctr in listcontrols)
                if (ctr.Bounds.Contains(p))
                    return false;
            return true;
        }
        public void MoveToLastlocation()
        {
            this.control_to_drag.Location = point;
        }
    }
}
