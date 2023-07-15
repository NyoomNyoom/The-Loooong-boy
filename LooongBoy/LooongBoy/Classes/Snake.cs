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
        private Point Direction = new();
        private List<Point> Body = new();

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

        //Direction get & set.
        public Point GetDirection()
        {
            return Direction;
        }

        public void SetDirection(Point Input)
        {
            Direction = Input;
        }

        //Body get and set methods.
        public List<Point> GetBody()
        {
            return Body;
        }

        public void SetBody(List<Point> input)
        {
            Body = input;
        }

        //Default constructor for the class
        public Snake()
        {
            AddSegment();
            SetDirection(new Point(1,0)); //Initial direction of facing right.
        }

        //Code to add a segment to the body
        public void AddSegment()
        {
            //Checking if there is a body to add to, or if it needs to be initilized.
            if(Body.Count > 0)
            {
                Body.Add(Body[Body.Count - 1]);
            }else if(Body.Count == 0) 
            {
                Body.Add(new Point(0, 0));
            }
            else
            {
                return;
            }
            
        }

    }
}
