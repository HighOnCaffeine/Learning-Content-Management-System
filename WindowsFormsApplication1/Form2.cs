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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private string user_id;
        private SqlDataReader userInfo;

        private void getUserData()
        {
            SqlConnection conn = SqlConn.Sql.makeConn();
            conn.Open();
            string sql = "SELECT * FROM student WHERE s_id = \'" + user_id + "\';";
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                System.Windows.Forms.MessageBox.Show(string.Format("{0}", sql));
                SqlDataReader sqldata = command.ExecuteReader();
                lbl_greet.Text += sqldata["fname"];
               // prepareView(sqldata);
                conn.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
                conn.Close();
            }
        }

        private void prepareView(SqlDataReader sql)
        {
            
        }

        public Form2(string user_id)
        {
            this.user_id = user_id;
            getUserData();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
