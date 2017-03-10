using System;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Windows.Forms;



namespace SKiJumping
{
    public partial class FrmSkijumping : Form
    {
        //TODO virheenkäsittely....

        private decimal _judgepoints = 0;
        private decimal _windpoints = 0;
        private decimal _stagepoints = 0;
        private decimal _lengthpoints = 0;

        private decimal _totalpoints = 0;

        Datahandling dhc = new Datahandling();

        public FrmSkijumping()
        {
            InitializeComponent();
            //annetaan testausta varten lähtöarvot
            txtMeters.Text = "5";
            txtStage.Text = "1,4";
            txtWind.Text = "1,4";
            txtkpoint.Text = "116";
            txtcreditscore.Text = "1,8";
            txtLength.Text = "124";
            nudJudge1.Text = "18";
            nudJudge2.Text = "18,5";
            nudJudge3.Text = "18,5";
            nudJudge4.Text = "19";
            nudJudge5.Text = "19";

            checkenabled(false);

            //syötetään myös combon lähtötiedot:
            /*cboJumper.Items.Add("Ahonen Janne");
            cboJumper.Items.Add("Malyz Adam");
            cboJumper.Items.Add("Schmidt Martin");
            cboJumper.Items.Add("Nieminen Toni");
            cboJumper.Items.Add("Schlierenzauer Gregor");
            cboJumper.Items.Add("Keituri Kalle");*/

            dhc.Firsttime = true;
            dhc.ClearTable(dataGridView1);
            dhc.Openconnection(dataGridView1);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cboJumper.SelectedIndex == -1)
            {
                MessageBox.Show("Anna hyppääjän nimi", "Hyppääjän nimi");
            }
            else
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

                    dhc.Jumper = cboJumper.Text;
                    dhc.Points = txtTotalPoints.Text;
                    if (rdbtnRound1.Checked == true)
                    {
                        dhc.Update = false;
                        dhc.Jno = cboJumper.SelectedIndex + 1;
                    }
                    else
                    {
                        dhc.Update = true;
                    }

                    dhc.CollectCompetitors(dataGridView1);

                    if (rdbtnRound2.Checked == true)
                    {
                        cboJumper.Items.Remove(cboJumper.SelectedItem);
                    }
                }
            }
        }
        private void btnHill_Click(object sender, EventArgs e)
        {
            frmHill fHill = new frmHill();

            fHill.ShowDialog();

            if (fHill.Kpoint != null)
            {
                txtkpoint.Text = fHill.Kpoint;
                txtcreditscore.Text = fHill.Credit;
                lblHillName.Text = fHill.Hill;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = "Haluatko varmasti lopettaa?";
            string caption = "Lopetus";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, btn);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                dhc.Closeconnection();
                this.Close();
            }
        }

        private void txtTotalPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dhc.Firsttime = false;
            dhc.ClearTable(dataGridView1);
            checkenabled(false);
            cboJumper.Items.Clear();

        }

        private void btnReadJumpers_Click(object sender, EventArgs e)
        {
            openJumperDialog.Filter = "Tekstitiedostot (*.txt)|*.txt|Kaikki tiedostot (*.*)|*.*";
            openJumperDialog.Multiselect = false;
            DialogResult result = openJumperDialog.ShowDialog();

            if (result == DialogResult.OK) 
            {
                string file = openJumperDialog.FileName;
                try
                {
                    StreamReader sr = new StreamReader(file);
                    string line = sr.ReadLine();

                    while (line != null)
                    {
                        cboJumper.Items.Add(line);
                        line = sr.ReadLine();
                    }

                    checkenabled(true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Virhe: " + ex.Message);
                }
            }
        }
        private void checkenabled(bool enabled)
        {
            if (enabled == false)
            {
                btnCalculate.Enabled = false;
                btnClear.Enabled = false;
                rdbtnRound2.Enabled = false;
            }
            else
            {
                btnCalculate.Enabled = true;
                btnClear.Enabled = true;
                rdbtnRound2.Enabled = true;
            }

        }

        private void rdbtnRound2_Click(object sender, EventArgs e)
        {
            string message = "Haluatko varmasti aloittaa toisen kierroksen?";
            string caption = "Toimintoa ei voi peruuttaa! ";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, btn,MessageBoxIcon.Exclamation);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                rdbtnRound1.Enabled = false;

            }
            else
            {
                rdbtnRound1.Checked = true;
            }
        }
    }
}