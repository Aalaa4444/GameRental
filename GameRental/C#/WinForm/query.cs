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
    public partial class query : Form
    {
        public query()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");

            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = "SELECT Title FROM [Game] where GAME_ID IN( select game_id from rent group by game_id having count(ACC_ID) = (select max(x.High) from(select count(*) as High from rent Group by GAME_ID) as x))";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView4.AutoGenerateColumns = true;

            dataGridView4.DataSource = dt;

            con1.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");

            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = "SELECT Title FROM [Game] where game_id not in(select distinct GAME_ID from rent where S_Date between '2022-04-01' and '2022-04-30')";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.AutoGenerateColumns = true;
           
            dataGridView1.DataSource = dt;
            
            con1.Close();

        }



        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");

            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = "select Username,ACC_ID from [Account] where ACC_ID IN (select ACC_ID from rent Group by ACC_ID having count(*)=(select max(rcount) from (select count(*) as rcount from rent where s_date between '2022-02-01' and '2022-04-30'group by ACC_ID)as y))";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView5.AutoGenerateColumns = true;

            dataGridView5.DataSource = dt;

            con1.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");

            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = " Select Distinct Vendor  from [Game] Where Vendor Not IN (Select Distinct Vendor From Game where Game_ID IN (Select Game_ID From Rent Where S_Date between '2022-02-01' and '2022-04-30'))";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView2.AutoGenerateColumns = true;

            dataGridView2.DataSource = dt;

            con1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");

            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = "WITH lmgame as (select* from rent where s_date between '2022-01-29' and '2022-04-30') select vendor from [game] where Game_ID IN(select game_id from lmgame group by game_id having count(ACC_ID) = (select max(x.High) from(select count(*) as High from lmgame Group by GAME_ID) as x))";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView6.AutoGenerateColumns = true;

            dataGridView6.DataSource = dt;

            con1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=USER;Initial Catalog=GAMES;Integrated Security=True");

            con1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con1;
            cmd.CommandText = " Select Distinct vendor  from [Game]  where vendor not in (select distinct vendor from game where year = 2021 )";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView3.AutoGenerateColumns = true;

            dataGridView3.DataSource = dt;

            con1.Close();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
