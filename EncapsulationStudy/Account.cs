using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationStudy
{
    internal class Account
    {
        //Encapsulation
        private int _Speed;

        public int Speed
        {
            get { return CalcSpeed(); }

            set { _Speed = value; }
        }

        private void Calculate()
        {
            _Speed = 0;
        }

        private int CalcSpeed()
        {
            return _Speed * 2;
        }
    }
}
