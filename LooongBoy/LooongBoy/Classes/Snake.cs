using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooongBoy.Classes
{
    public class Snake
    {
        private bool IsDead = false;
        private Point Direction = new Point();
        private List<Point> Body = new List<Point>();

        //Writing get and set methods for the private variables.
        //IsDead get & set method.
        public bool GetIsDead()
        {
            return IsDead;
        }

        public void SetIsDead(bool Input)
        {
            IsDead = Input;
        }


    }
}
