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
    public partial class up : Form
    {
        public up()
        {
            InitializeComponent();
        }

        private void up_Load(object sender, EventArgs e)
        {
            //label6.Text = mainForm.SetValueForText1;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Account SET Username ='" + textBox1.Text + "' , Password= '" + textBox2.Text + "' , E_mail= '" + textBox3.Text + "' where ACC_ID='" + mainForm.SetValueForText2 + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update was successfully completed");
            this.Hide();
        }
    }
}
