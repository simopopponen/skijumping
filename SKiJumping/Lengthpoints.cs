using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Lengthpoints
    {
        private decimal _kpoint;
        private decimal _length;
        private decimal _creditscore;
        private decimal _point;
        private decimal _lpoint;

        public decimal KPoint
        {
            get { return _kpoint; }
            set { _kpoint = value; }
        }

        public decimal Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public decimal Creditscore
        {
            get { return _creditscore; }
            set { _creditscore = value; }
        }

        public decimal CalculateLengthPoints()
        {
            //8 = 124 - 116
            _lpoint = _length - _kpoint;
            _point = 60 + _lpoint * _creditscore;

            return _point;
        }
    }
}
