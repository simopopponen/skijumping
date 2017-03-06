using System;
using System.Collections.Generic;
using System.Globalization;
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
        private string _hlpwind2;

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
            
            _hlpwind = Convert.ToString(_windpoints, CultureInfo.InvariantCulture);
            
            for (int i = 0; i < _hlpwind.Length; i++)
            {
                if (_hlpwind.Substring(i, 1) != ",") continue;
                _hlpwind2 = _hlpwind.Substring(i + 1);
                i = _hlpwind.Length;
            }

            _windpoints = Math.Ceiling(_windpoints);
            _windpoints = _windpoints - 1; 

            if (int.Parse(_hlpwind2) >= 3 && int.Parse(_hlpwind2) < 7)
            {
                _windpoints = _windpoints + 0.5m;
            }
            else if (int.Parse(_hlpwind2) >= 7 )
            {
                _windpoints = _windpoints +1;
            }
            else
            {
                _windpoints = _windpoints;
            }
            _windpoints = _windpoints * _creditscore;

            return _windpoints;
        }
    }
}
