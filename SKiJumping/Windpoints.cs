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
        private decimal _windpoints;
        private string _hlpwind;
        private string _hlpwind2;

        public decimal Wind { get; set; }

        public decimal KPoint { get; set; }

        public decimal CreditScore { get; set; }

        public decimal CalculateWindpoints()
        {
            _windpoints = Wind * (KPoint - 36) / 20;

            if (_windpoints != 0)
            {
                _hlpwind = Convert.ToString(_windpoints, CultureInfo.InvariantCulture);


                for (int i = 0; i < _hlpwind.Length; i++)
                {
                    if (_hlpwind.Substring(i, 1) == "," || _hlpwind.Substring(i, 1) == ".")
                    {
                        _hlpwind2 = _hlpwind.Substring(i + 1, 1);
                        i = _hlpwind.Length;
                    }
                }

                _windpoints = Math.Ceiling(_windpoints);
                _windpoints = _windpoints - 1;

                if (_hlpwind2 != null)
                {
                    if (int.Parse(_hlpwind2) >= 3 && int.Parse(_hlpwind2) < 7)
                    {
                        _windpoints = _windpoints + 0.5m;
                    }
                    else if (int.Parse(_hlpwind2) >= 7)
                    {
                        _windpoints = _windpoints + 1;
                    }
                    else
                    {

                    }
                }
            }
            _windpoints = _windpoints * CreditScore;

            return _windpoints;
        }
    }
}
