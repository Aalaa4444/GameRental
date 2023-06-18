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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
           // con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            con.Open();
            //SqlDataReader reader;
            if (cbshowpassword.Checked)
            {
                //cmd.CommandText = "INSERT INTO CUSTOMER(NAME,USER_ID,E_MAIL,AGE,PHONE,ADDRESS) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "')";
                //cmd.CommandText = "INSERT INTO USER SELECT * FROM CUSTOMER WHERE USER_ID='" + textBox2.Text + "';
                cmd.CommandText = "INSERT INTO Account(Username,Password,E_mail,Name) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd3.CommandText = "SELECT ACC_ID FROM Account WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "' ";
                //reader1.GetValue(0)
                SqlDataReader reader1 = cmd3.ExecuteReader();
                if (reader1.Read())
                {
                    cmd2.CommandText = "INSERT INTO Admin(ACC_ID) VALUES ('" + reader1.GetValue(0) + "')";

                }
                reader1.Close();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                

                
                con.Close();
                //mainForm form2 = new mainForm();
                //form2.Show();
                this.Hide();
                mainForm form2 = new mainForm();
                //form2.Names = textBox1.Text;
                form2.Show();


            }
            else
            {
                cmd.CommandText = "INSERT INTO Account(Username,Password,E_mail,Name) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox1.Text + "')";
                cmd.ExecuteNonQuery();
                cmd3.CommandText = "SELECT ACC_ID FROM ACCOUNT  WHERE Username='" + textBox1.Text + "' AND Password='" + textBox2.Text + "' ";
                SqlDataReader reader2 = cmd3.ExecuteReader();
                if (reader2.Read())
                {
                    cmd2.CommandText = "INSERT INTO Customer(ACC_ID,Age,Phone) VALUES ('" + reader2.GetValue(0) + "' ,'" + textBox4.Text + "' , '" + textBox5.Text + "')";
                    
                }
                reader2.Close();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();


                con.Close();

                this.Hide();
                mainForm form2 = new mainForm();
                //form2.Names = textBox1.Text;
                form2.Show();

            }

            

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                mainForm form2 = new mainForm();
                form2.Show();
                this.Hide();
            }

        }

        
        */
       
        /*
        private void btn_login_2_Click(object sender, EventArgs e)
        {

        }
    
        */

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "admin" || txt_Password.Text == "admin")
                {
                    this.Hide();
                    Form2 fh = new Form2();
                    fh.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Yor are Loggin Detail Is Invalied", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.Hide();
            Form3 fh = new Form3();
            fh.Show();
            this.Hide();
        }
         */
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
             this.Hide();
             mainForm form2 = new mainForm();
             form2.Show();
            
        }
    }
}
