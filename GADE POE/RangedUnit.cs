//Rah5i  Mitchell Dreyer 18000499

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_POE
{
    class RangedUnit : Unit
    {
   
        public int X_pos
        {
            get { return x_pos; }
            set { x_pos = value; }
        }

        public int Y_pos
        {
            get { return y_pos; }
            set { y_pos = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Attack_Range
        {
            get { return attack_range; }
            set { attack_range = value; }
        }

        public string Faction
        {
            get { return faction; }
            set { faction = value; }
        }


        public override int combat()
        {
            return combat();
        }
        public override int moveToNewPos()
        {
            return moveToNewPos();
        }
        public override int Death()
        {
            return Death();
        }
        public override int GetHashCode()
        {
            return GetHashCode();
        }
        public override int rangeCalc()
        {
            return rangeCalc();
        }
        public override int returnPos()
        {
            return returnPos();
        }
        public override string tostring()
        {
            return tostring();
        }
    }
}
