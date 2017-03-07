using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Judgepoints
    {
        private decimal _judgepoints;

        public decimal Judge1 { get; set; }

        public decimal Judge2 { get; set; }

        public decimal Judge3 { get; set; }

        public decimal Judge4 { get; set; }

        public decimal Judge5 { get; set; }

        public decimal CalculateJudgePoints()
        {
            //Add values to list object
            List<decimal> jpointlist = new List<decimal>();
            jpointlist.Add(Judge1);
            jpointlist.Add(Judge2);
            jpointlist.Add(Judge3);
            jpointlist.Add(Judge4);
            jpointlist.Add(Judge5);
            //let's sort them so we can take only values from the middle
            jpointlist.Sort();

            for (var i = 0; i < 4; i++)
            {
                if (i > 0 && i < 4)
                    _judgepoints = _judgepoints + jpointlist[i];
            }

            return _judgepoints;
        }


    }
}
