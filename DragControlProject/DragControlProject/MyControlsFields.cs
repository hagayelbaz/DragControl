using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragControlNamespace
{
     partial class MyControls
    {
        //list the all controls from user form
        private IEnumerable<Control> getAllControls(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => getAllControls(ctrl)).Concat(controls);
        }
        //Returns the name of the control you reached
        public string getStopedControlName;

        private Control my;
        private Control owner;//user form
        private int selectedConstructors;

        private List<Control> GetAllControls(Control control) => this.getAllControls(control).ToList();//convert to list

        private List<Control> usercontrol;//list all controls

        public List<Control> GetAllControl { get => this.GetAllControls(this.owner); }//for you can use them

        //for use 
        private Control[] except;
        private Type[] typeexcept;
    }
}
