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
    public partial class ForAdmin : Form
    {
        //public string Names { get; set; }
        public ForAdmin()
        {
            InitializeComponent();
        }

        private void ForAdmin_Load(object sender, EventArgs e)
        {
            label6.Text = mainForm.SetValueForText1;
            //label6.Text = Names;
            // TODO: This line of code loads data into the 'gameRentalDataSet.GAME' table. You can move, or remove it, as needed.
            // this.gAMETableAdapter.Fill(this.gameRentalDataSet.GAME);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Game(Title,vendor,Year,Category ,ACC_ID) VALUES('" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + textBox3.Text + "' , '" + textBox4.Text + "' ," + mainForm.SetValueForText2 + " )";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insertion was successfully completed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE Game SET Year ='" + textBox3.Text + "' , Title= '" + textBox1.Text + "' , Category= '" + textBox4.Text + "' where vendor='" + textBox2.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update was successfully completed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // this.gAMETableAdapter.Fill(gameRentalDataSet.GAME);
            bindgrid();

        }
        private void bindgrid()
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            
            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = "SELECT * FROM [Game] ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            
            dataGridView1.AutoGenerateColumns=false;
            dataGridView1.ColumnCount=4;
            dataGridView1.Columns[0].HeaderText = "Title";
            dataGridView1.Columns[0].DataPropertyName= "Title";
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[1].DataPropertyName = "Category";
            dataGridView1.Columns[2].HeaderText = "vendor";
            dataGridView1.Columns[2].DataPropertyName = "vendor";
            dataGridView1.Columns[3].HeaderText = "Year";
            dataGridView1.Columns[3].DataPropertyName = "Year";
            dataGridView1.DataSource = dt;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Game WHERE Title= '" + textBox1.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete was successfully completed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            up fo = new up();
            fo.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            // con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            //SqlCommand cmd2 = new SqlCommand();
            //cmd2.Connection = con;
            con.Open();
            cmd3.CommandText = "SELECT Game_ID,Year, Category,vendor FROM Game WHERE Title= '" + textBox1.Text + "' ";
            cmd3.ExecuteNonQuery();
            SqlDataReader reader2 = cmd3.ExecuteReader();
            if (reader2.Read())
            {
               // cmd2.CommandText = "INSERT INTO Browsee(ACC_ID,Game_ID) VALUES ( " + mainForm.SetValueForText2 + "  ," + reader2.GetValue(0) + " ) ";
                textBox5.Text = reader2.GetValue(1).ToString();
                textBox6.Text = reader2.GetValue(2).ToString();
                textBox7.Text = reader2.GetValue(3).ToString();
            }

            reader2.Close();
            //cmd2.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            query q = new query();
            q.Show();
        }
    }
}
