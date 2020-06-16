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
    public partial class Form1 : Form
    {
        string user_id;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // btn lgin click
            bool bit = auth_login();
            if (bit) route_login();
            tbemail.Text = "";
            tbpassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool auth_login()
        {
            SqlConnection conn = SqlConn.Sql.makeConn();
            conn.Open();
            string sql = "SELECT * FROM auth_info WHERE username = \'" + tbemail.Text + "\';";
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if ((string)reader[3] == tbpassword.Text)
                {
                    System.Windows.Forms.MessageBox.Show("Login Successful");
                    user_id = (string) reader["user_id"];
                }
                else
                    throw new Exception();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Username/Password");
                conn.Close();
                return false;
            }
            
        }

        private void route_login()
        {
            System.Windows.Forms.Form form = null;
            string table = null;

            string[] iden = user_id.Split('_');
            System.Windows.Forms.MessageBox.Show(string.Format("{0}", iden[0]));
            switch (iden[0])
            {
                case "S":
                    {
                        form = (System.Windows.Forms.Form)new Form2(user_id);
                        table = "student";
                    }
                    break;

                case "A":
                    form = (System.Windows.Forms.Form)new Form5(user_id);
                    table = "admin";
                    break;

                case "C":
                    form = (System.Windows.Forms.Form)new Form3(user_id);
                    table = "coordinator";
                    break;

                case "T":
                    form = (System.Windows.Forms.Form)new Form4(user_id);
                    table = "teacher";
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Error");
                    break;
            }

            /*SqlConnection conn = SqlConn.Sql.makeConn();
            conn.Open();
            string sql = "SELECT * FROM " + table + " WHERE s_id = \'" + user_id + "\';";
            SqlCommand command = new SqlCommand(sql, conn);
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                conn.Close();
            }
            catch (Exception e)
            {
                conn.Close();
            }
            */
            if (form != null)
            {
                this.Hide();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }
    }
}
