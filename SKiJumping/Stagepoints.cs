using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Stagepoints
    {
        private decimal _impact;

        public decimal Stage { get; set; }

        public decimal Meters { get; set; }

        public decimal CreditScore { get; set; }

        public decimal CalculateStageImpact()
        {
            _impact = Stage * Meters;
            _impact = _impact * CreditScore;

            return _impact;
        }
    }
}
