//Rah5i  Mitchell Dreyer 18000499

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    abstract class Unit
    {
        protected int x_pos;
        protected int y_pos;
        protected int health;
        protected int speed;
        protected int attack;
        protected int attack_range;
        protected string faction;
        //protected string image;


        abstract public int moveToNewPos();
        abstract public int combat();
        abstract public int rangeCalc();
        abstract public int returnPos();
        abstract public int Death();
        abstract public string tostring();
    }
}
