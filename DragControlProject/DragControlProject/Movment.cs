
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DragControlNamespace
{
    public class Movment
    {
        public enum Diraction
        {
            Left,
            Right,
            Up,
            Down          
        }
        public int Speed
        {
            get => this.speed;
            set
            {
                if (value <= 0)
                     throw new Exception("the value cano't be less then zero");
                this.speed = value;
            }
        }

        public Diraction GetDiraction { get => this.diraction; }
        public Diraction SetDiraction { set => this.diraction = value; }

        private int speed=1;
        private Control mycontrol;
        private Diraction diraction = Diraction.Down;//defult diraction
        private Timer timer = new Timer();

        
        public Movment(Control control)
        {
            this.mycontrol = control;
            this.timer.Enabled = false;
            this.timer.Interval = 10;
            this.timer.Tick += StartMove;
        }

        private void StartMove(object sender, EventArgs e)
        {
            if (this.diraction == Diraction.Up)
                mycontrol.Location = new Point(mycontrol.Location.X, mycontrol.Location.Y - this.speed);
            if (this.diraction == Diraction.Down)
                mycontrol.Location = new Point(mycontrol.Location.X, mycontrol.Location.Y + this.speed);
            if (this.diraction == Diraction.Left)
                mycontrol.Location = new Point(mycontrol.Location.X - this.speed, mycontrol.Location.Y);
            if (this.diraction == Diraction.Right)
                mycontrol.Location = new Point(mycontrol.Location.X + this.speed, mycontrol.Location.Y);
        }          
        public void Stop()
        {
            timer.Stop();
        }
        public void Start()
        {
            timer.Start();
        }      
    }
}
