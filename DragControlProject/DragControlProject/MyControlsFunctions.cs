using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragControlNamespace
{
    partial class MyControls
    {   
        //Find if there is a control in the entire defined control areaFind if there is a control in the entire defined control area
        public bool ExsistControlInLocation()
        {
            foreach (Control ctrl in this.usercontrol)
            {
                if (my.Bounds.IntersectsWith(ctrl.Bounds))
                {
                    this.getStopedControlName = ctrl.Name;
                    return true;
                }
            }
            return false;
        }     
    }
}
