using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKiJumping
{
    public partial class frmHill : Form
    {
        public frmHill()
        {
            InitializeComponent();
        }

        private string _kpoint;
        private string _credit;
        private string _hill;

        public string Kpoint { get; set; }
        public string Credit { get; set; }
        public string Hill { get; set; }




        private void frmHill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skiJumpingDataSet.Hills' table. You can move, or remove it, as needed.
            this.hillsTableAdapter.Fill(this.skiJumpingDataSet.Hills);


        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            this.Credit = _credit;
            this.Kpoint = _kpoint;
            this.Hill = _hill;  
            this.Close();
            
        }

        private void dataGridHill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            DataGridViewRow selectedRow = dataGridHill.Rows[index];
            _hill = selectedRow.Cells[1].Value.ToString();
            _kpoint = selectedRow.Cells[2].Value.ToString();
            _credit = selectedRow.Cells[3].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}