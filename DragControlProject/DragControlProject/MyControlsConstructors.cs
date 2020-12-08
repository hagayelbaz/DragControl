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
        //Constructor

        public MyControls(Control owner, Control my)
        {
            this.owner = owner;
            this.my = my;
            this.selectedConstructors = 1;
            this.UpDate(this.selectedConstructors);
            this.owner.ControlAdded += delegate { this.UpDate(this.selectedConstructors); };
        }
        // A drag-and-drop control and an "owner" window (this), you can add specific controls that you can drag over
        public MyControls(Control owner, Control my, params Control[] Except)
        {
            this.owner = owner;
            this.my = my;
            this.except = Except;
            this.selectedConstructors = 2;
            this.UpDate(this.selectedConstructors);
            this.owner.ControlAdded += delegate { this.UpDate(this.selectedConstructors); };
        }
        // A towable control and an "owner" window (this), you can add types of controls that you can drag over
        // How to use: (Exemple) <code>   var drag = new DragControl(this,button1,typeof(PictureBox)); </code>      
        public MyControls(Control owner, Control my, params Type[] typeExcept)
        {
            this.owner = owner;
            this.my = my;
            this.typeexcept = typeExcept;
            this.selectedConstructors = 3;
            this.UpDate(this.selectedConstructors);
            this.owner.ControlAdded += delegate { this.UpDate(this.selectedConstructors); };
        }
    }
}
