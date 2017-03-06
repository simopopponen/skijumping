using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Stagepoints
    {
        private decimal _stage;
        private decimal _meters;
        private decimal _impact;
        private decimal _creditscore;

        public decimal Stage
        {
            get { return _stage; }
            set { _stage = value; }
        }

        public decimal Meters
        {
            get { return _meters; }
            set { _meters = value; }
        }

        public decimal CreditScore
        {
            get { return _creditscore; }
            set { _creditscore = value; }
        }
        public decimal CalculateStageImpact()
        {
            _impact = _stage * _meters;
            _impact = _impact * _creditscore;

            return _impact;
        }
    }
}
