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
        private void UpDate(int selectedConstructor)
        {            
            this.usercontrol = this.getAllControls(this.owner).ToList();
            switch (selectedConstructor)
            {
                case 1:
                    {
                        this.usercontrol.Remove(my);//my control d'ont count 
                    }
                    break;
                case 2:
                    {
                        List<Control> newlist = new List<Control>();
                        //adding just d'ont selected controls
                        for (int i = 0; i < usercontrol.Count; i++)
                            if (!this.except.Contains(usercontrol[i]) && usercontrol[i].Name != my.Name)
                                newlist.Add(usercontrol[i]);
                        this.usercontrol = newlist;
                    }
                    break;
                case 3:
                    {
                        List<Control> newlist = new List<Control>();
                        List<Type> typeexcept1 = new List<Type>();
                        //adding just d'ont selected controls
                        for (int i = 0; i < this.typeexcept.Length; i++)
                            typeexcept1.Add(this.typeexcept[i]);
                        for (int i = 0; i < usercontrol.Count; i++)
                            if (!typeexcept1.Contains(usercontrol[i].GetType()) && usercontrol[i].Name != my.Name)
                                newlist.Add(usercontrol[i]);
                        this.usercontrol = newlist;
                    }
                    break;
                default:
                    throw new Exception("selected number is unavailable");
            }
        }
    }
}
