using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKiJumping
{
    public partial class frmSkijumping : Form
    {
        private decimal _totalpoints = 0;

        public frmSkijumping()
        {
            InitializeComponent();
            txtMeters.Text = "5";
            txtStage.Text = "1,4";
            txtWind.Text = "1,4";
            txtkpoint.Text = "116";
            txtcreditscore.Text = "1,8";
            txtJudge1.Text = "18";
            txtJudge2.Text = "18,5";
            txtJudge3.Text = "18,5";
            txtJudge4.Text = "19";
            txtJudge5.Text = "15";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            Judgepoints jpoint = new Judgepoints();

            jpoint.Judge1 = Convert.ToDecimal(txtJudge1.Text);
            jpoint.Judge2 = Convert.ToDecimal(txtJudge2.Text);
            jpoint.Judge3 = Convert.ToDecimal(txtJudge3.Text);
            jpoint.Judge4 = Convert.ToDecimal(txtJudge4.Text);
            jpoint.Judge5 = Convert.ToDecimal(txtJudge5.Text);
            
            Lengthpoints lpoint = new Lengthpoints();
            lpoint.KPoint = Convert.ToDecimal(txtkpoint.Text);
            lpoint.Creditscore = Convert.ToDecimal(txtcreditscore.Text);
            lpoint.Length = Convert.ToDecimal(txtLength.Text);

            Stagepoints spoint = new Stagepoints();
            spoint.Meters = Convert.ToDecimal(txtMeters.Text);
            spoint.Stage = Convert.ToDecimal(txtStage.Text);
            spoint.CreditScore = Convert.ToDecimal(txtcreditscore.Text);

            Windpoints wpoint = new Windpoints();
            wpoint.Wind = Convert.ToDecimal(txtWind.Text);
            wpoint.KPoint = Convert.ToDecimal(txtkpoint.Text);
            wpoint.CreditScore = Convert.ToDecimal(txtcreditscore.Text);

            _totalpoints = jpoint.CalculateJudgePoints();
            _totalpoints = _totalpoints + lpoint.CalculateLengthPoints();
            _totalpoints = _totalpoints - spoint.CalculateStageImpact();
            _totalpoints = _totalpoints + Convert.ToDecimal(wpoint.CalculateWindpoints());

            

            txtTotalPoints.Text = Convert.ToString(_totalpoints);
        }

        private void btnHill_Click(object sender, EventArgs e)
        {
            frmHill fHill = new frmHill();
            fHill.Show();
            

        }
    }
}
