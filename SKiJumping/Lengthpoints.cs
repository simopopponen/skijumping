using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Lengthpoints
    {
        private decimal _point;
        private decimal _lpoint;

        public decimal KPoint { get; set; }

        public decimal Length { get; set; }

        public decimal Creditscore { get; set; }

        public decimal CalculateLengthPoints()
        {
            _lpoint = Length - KPoint;
            _point = 60 + _lpoint * Creditscore;
            
            return _point;
        }
    }
}
