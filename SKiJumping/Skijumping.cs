using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKiJumping
{
    public partial class FrmSkijumping : Form
    {
        private decimal _judgepoints = 0;
        private decimal _windpoints = 0;
        private decimal _stagepoints = 0;
        private decimal _lengthpoints = 0;
        
        private decimal _totalpoints = 0;

        public FrmSkijumping()
        {
            InitializeComponent();
            txtMeters.Text = "5";
            txtStage.Text = "1,4";
            txtWind.Text = "1,4";
            txtkpoint.Text = "116";
            txtcreditscore.Text = "1,8";
            nudJudge1.Text = "18";
            nudJudge2.Text = "18,5";
            nudJudge3.Text = "18,5";
            nudJudge4.Text = "19";
            nudJudge5.Text = "19";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            {
                Judgepoints jpoint = new Judgepoints
                {
                    Judge1 = Convert.ToDecimal(nudJudge1.Text),
                    Judge2 = Convert.ToDecimal(nudJudge2.Text),
                    Judge3 = Convert.ToDecimal(nudJudge3.Text),
                    Judge4 = Convert.ToDecimal(nudJudge4.Text),
                    Judge5 = Convert.ToDecimal(nudJudge5.Text)
                };


                Lengthpoints lpoint = new Lengthpoints
                {
                    KPoint = Convert.ToDecimal(txtkpoint.Text),
                    Creditscore = Convert.ToDecimal(txtcreditscore.Text),
                    Length = Convert.ToDecimal(txtLength.Text)
                };

                Stagepoints spoint = new Stagepoints
                {
                    Meters = Convert.ToDecimal(txtMeters.Text),
                    Stage = Convert.ToDecimal(txtStage.Text),
                    CreditScore = Convert.ToDecimal(txtcreditscore.Text)
                };

                Windpoints wpoint = new Windpoints
                {
                    Wind = Convert.ToDecimal(txtWind.Text),
                    KPoint = Convert.ToDecimal(txtkpoint.Text),
                    CreditScore = Convert.ToDecimal(txtcreditscore.Text)
                };

                _judgepoints = jpoint.CalculateJudgePoints();
                _lengthpoints = lpoint.CalculateLengthPoints();
                _stagepoints = spoint.CalculateStageImpact();
                _windpoints = wpoint.CalculateWindpoints();

                _totalpoints = _judgepoints + _windpoints + _lengthpoints - _stagepoints;

                txtJudgePoints.Text = Convert.ToString(_judgepoints, CultureInfo.InvariantCulture);
                txtLengthpoints.Text = Convert.ToString(_lengthpoints, CultureInfo.InvariantCulture);
                txtStagepoints.Text = Convert.ToString(_stagepoints, CultureInfo.InvariantCulture);
                txtWindpoints.Text = Convert.ToString(_windpoints, CultureInfo.InvariantCulture);

                txtTotalPoints.Text = Convert.ToString(_totalpoints, CultureInfo.InvariantCulture);


            }
        }

        private void btnHill_Click(object sender, EventArgs e)
        {
            frmHill fHill = new frmHill();
            fHill.Show();
            

        }
    }
}
