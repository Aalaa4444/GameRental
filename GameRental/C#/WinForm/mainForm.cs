using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WinForm
{
   
    public partial class mainForm : Form
    {
        public static string SetValueForText1;
        public static int SetValueForText2;

        public mainForm()
        {
            InitializeComponent();
        }


        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            
            try
            {
                SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
                // con.Open();

                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = con;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                con.Open();
                cmd3.CommandText = "SELECT ACC_ID FROM Account WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "' ";
                cmd3.ExecuteNonQuery();
                SqlDataReader reader1 = cmd3.ExecuteReader();
                
                if (reader1.Read())
                {
                    cmd2.CommandText = "SELECT ACC_ID FROM Admin WHERE ACC_ID='" + reader1.GetValue(0) + "' ";
                    SetValueForText2 = (int)reader1.GetValue(0);
                    reader1.Close();
                    cmd3.ExecuteNonQuery();
                    reader1 = cmd2.ExecuteReader();
                    
                    
                    if (reader1.Read())
                    {
                        
                        reader1.Close();
                        cmd2.ExecuteNonQuery();
                        //cmd2.ExecuteNonQuery();
                        con.Close();
                        this.Hide();
                        ForAdmin fA = new ForAdmin();
                        fA.Show();
                    }
                    else
                    {
                        reader1.Close();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        this.Hide();
                        Operation f = new Operation();
                        f.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    reader1.Close();
                    cmd3.ExecuteNonQuery();
                    con.Close();
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
