using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Windpoints
    {
        private decimal _wind;
        private decimal _kpoint;
        private decimal _windpoints;
        private decimal _creditscore;
        private string _hlpwind;

        public decimal Wind
        {
            get { return _wind; }
            set { _wind = value; }
        }

        public decimal KPoint
        {
            get { return _kpoint; }
            set { _kpoint = value; }
        }
        public decimal CreditScore
        {
            get { return _creditscore; }
            set { _creditscore = value; }
        }

        public decimal CalculateWindpoints()
        {
            _windpoints = _wind * (_kpoint - 36) / 20;
            
            //_windpoints = 
            _hlpwind = Convert.ToString(_windpoints);
            _hlpwind = _hlpwind.Substring(_hlpwind.Length - 1);
            _windpoints = Math.Round(_windpoints);

            if (int.Parse(_hlpwind) < 3)
            {
                _windpoints = _windpoints - 1;
            }
            else if (int.Parse(_hlpwind) >= 3 && int.Parse(_hlpwind) < 7)
            {
                _windpoints = _windpoints + 0.5m;
            }
            else
            {
                _windpoints = _windpoints +1;
            }
            _windpoints = _windpoints * _creditscore;

            return _windpoints;
        }
    }
}
