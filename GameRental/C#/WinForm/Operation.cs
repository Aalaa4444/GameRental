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
    public partial class Operation : Form
    {
        //public string Names { get; set; }
        public Operation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            // con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            con.Open();
            cmd3.CommandText = "SELECT Game_ID FROM Game WHERE Title= '" + textBox1.Text + "' ";
            cmd3.ExecuteNonQuery();
            SqlDataReader reader2 = cmd3.ExecuteReader();
            if (reader2.Read())
            {
                cmd2.CommandText = "INSERT INTO Rent(S_Date,E_Date,ACC_ID,Game_ID) VALUES ( '" + textBox3.Text + "','" + textBox2.Text + "'," + mainForm.SetValueForText2 + "  ," + reader2.GetValue(0) + " ) ";
                MessageBox.Show("RENT was successfully completed");
            }
            reader2.Close();
            cmd2.ExecuteNonQuery();
            con.Close();



        }

        private void Operation_Load(object sender, EventArgs e)
        {
            label6.Text = mainForm.SetValueForText1;
            // TODO: This line of code loads data into the 'gAMESDataSet1.Game' table. You can move, or remove it, as needed.
           // this.gameTableAdapter2.Fill(this.gAMESDataSet1.Game);
            // TODO: This line of code loads data into the 'gAMESDataSet.Game' table. You can move, or remove it, as needed.
            //this.gameTableAdapter1.Fill(this.gAMESDataSet.Game);
            /*
            // TODO: This line of code loads data into the 'gameRentalDataSet.RENT' table. You can move, or remove it, as needed.
            this.rENTTableAdapter.Fill(this.gameRentalDataSet.RENT);
            // TODO: This line of code loads data into the 'gameRentalDataSet.BROWSE' table. You can move, or remove it, as needed.
            this.bROWSETableAdapter.Fill(this.gameRentalDataSet.BROWSE);
            // TODO: This line of code loads data into the 'gameRentalDataSet.GAME' table. You can move, or remove it, as needed.
            this.gAMETableAdapter.Fill(this.gameRentalDataSet.GAME);
            */
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].HeaderText = "Title";
            dataGridView1.Columns[0].DataPropertyName = "Title";
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[1].DataPropertyName = "Category";
            dataGridView1.Columns[2].HeaderText = "vendor";
            dataGridView1.Columns[2].DataPropertyName = "vendor";
            dataGridView1.Columns[3].HeaderText = "Year";
            dataGridView1.Columns[3].DataPropertyName = "Year";
            dataGridView1.DataSource = dt;

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            bindgrid();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");
            // con.Open();

            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = con;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            con.Open();
            cmd3.CommandText = "SELECT Game_ID,Year, Category,vendor FROM Game WHERE Title= '" + textBox1.Text + "' ";
            cmd3.ExecuteNonQuery();
            SqlDataReader reader2 = cmd3.ExecuteReader();
            if (reader2.Read())
            {
                cmd2.CommandText = "INSERT INTO Browsee(ACC_ID,Game_ID) VALUES ( " + mainForm.SetValueForText2 + "  ," + reader2.GetValue(0) + " ) ";
                textBox4.Text = reader2.GetValue(1).ToString();
                textBox5.Text = reader2.GetValue(2).ToString();
                textBox6.Text = reader2.GetValue(3).ToString();
            }
            
            reader2.Close();
            cmd2.ExecuteNonQuery();
            con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            up fo = new up();
            fo.Show();
        }
    }
}
