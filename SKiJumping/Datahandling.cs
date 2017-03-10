using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SKiJumping
{
    class Datahandling
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SkiJumping.mdf;Integrated Security=True;Connect Timeout=30");

        private string _jumper;
        private string _points;
        private bool _update;
        private int _jno;
        private bool _firsttime;

        public string Jumper
        {
             set { _jumper = value; }
        }

        public string Points
        {
            set { _points = value; }
        }

        public bool Update
        {
            set { _update = value; }
        }

        public bool Firsttime
        {
            set { _firsttime = value; }
        }

        public int Jno
        {
            set { _jno = value; }
        }

        public void  Openconnection(DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "select * from [table]";
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                da = new SqlDataAdapter(sql, con);
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        }
        public void Closeconnection()
        {
            con.Close();
        }

        public void CollectCompetitors(DataGridView dgv)
        {
            string sql;
            DataTable dt = new DataTable();

            if (_update == false)
            {
                sql = "INSERT INTO [TABLE] ([id], [name], [round1], [total])" +
                    " VALUES (" + _jno + ",'" + _jumper + "'," + _points + "," + _points + ")";
            }
            else
            {
                sql = "UPDATE [TABLE] SET [round2] = " + _points +
                    ", [total] = [total] + " + _points + " WHERE NAME = '" + _jumper + "'";
            }

            cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            dgv.DataSource = null;

            sql = "select * from [table] order by total desc";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            
            dgv.DataSource = dt;
            
        }
        public void ClearTable(DataGridView dgv)
        {
            
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (_firsttime == false)
            {
                string message = "Haluatko varmasti poistaa kaiken datan tietokannasta?";
                string caption = "Poisto";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult result;

                result = MessageBox.Show(message, caption, btn);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    cleardata();
                }
            }
            else
            {
                cleardata();
            }

            dgv.DataSource = null;

        }
        private void cleardata()
        {
            string sql = "truncate table [table]";

            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
}
