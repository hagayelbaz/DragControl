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
        //before start event -> check
        private void Has__end()
        {
            if (Finished != null)
                Finished(this, EventArgs.Empty);
        }
        private void Has_free()
        {
            if (Free != null)
                Free(this, EventArgs.Empty);
            this.mycontrols.getStopedControlName = null;
        }

        //to the corner
        private void Control_Location_Changed_Without_Controls(object sender, EventArgs e)
        {
            if (this.control_to_drag.Bottom >= this.Owner.ClientRectangle.Height || this.control_to_drag.Left <= 0||
               this.control_to_drag.Top<=0||this.control_to_drag.Right>=this.Owner.ClientRectangle.Width)
                Has__end();
            else
                Has_free();
            this.point = this.control_to_drag.Location;//saved last location
        }
        //to the control
        private void Control_Location_Changed_Include_Control(object sender, EventArgs e)
        {
            if (mycontrols.ExsistControlInLocation())
                Has__end();
            else
                Has_free();
            this.point = this.control_to_drag.Location;//saved last location
        }
        //to the corner & control
        private void Control_Location_Changed_Include_Control_And_Limit(object sender, EventArgs e)
        {
            if (this.control_to_drag.Bottom >= this.Owner.ClientRectangle.Height || this.control_to_drag.Left <= 0 ||
               this.control_to_drag.Top <= 0 || this.control_to_drag.Right >= this.Owner.ClientRectangle.Width||
                mycontrols.ExsistControlInLocation())
                Has__end();
            else
                Has_free();
            this.point = this.control_to_drag.Location;//saved last location
        }     
    }
}
