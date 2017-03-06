using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKiJumping
{
    class Judgepoints
    {
        private decimal _judge1;
        private decimal _judge2;
        private decimal _judge3;
        private decimal _judge4;
        private decimal _judge5;
        private decimal _judgepoints;

        public decimal Judge1
        {
            get { return _judge1; }
            set { _judge1 = value; }
        }

        public decimal Judge2
        {
            get { return _judge2; }
            set { _judge2 = value; }
        }
        public decimal Judge3
        {
            get { return _judge3; }
            set { _judge3 = value; }
        }
        public decimal Judge4
        {
            get { return _judge4; }
            set { _judge4 = value; }
        }
        public decimal Judge5
        {
            get { return _judge5; }
            set { _judge5 = value; }
        }

        public decimal CalculateJudgePoints()
        {
            //Add values to list object
            List<decimal> jpointlist = new List<decimal>();
            jpointlist.Add(_judge1);
            jpointlist.Add(_judge2);
            jpointlist.Add(_judge3);
            jpointlist.Add(_judge4);
            jpointlist.Add(_judge5);
            //let's sort them so we can take only values from the middle
            jpointlist.Sort();

            for (int i = 0; i < 4; i++)
            {
                if (i > 0 && i < 4)
                    _judgepoints = _judgepoints + jpointlist[i];
            }

            return _judgepoints;
        }


    }
}
