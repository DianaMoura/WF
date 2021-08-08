using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatientAdmission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Patient (FName,LName,Age,Ethnicity,Gender,BGroup,Email,PhoneNumber,RAdd) VALUES (@FName,@LName,@Age,@Ethnicity,@Gender,@BGroup,@Email,@PhoneNumber,@RAdd)",con );
            cmd.Parameters.AddWithValue("@FName",textBox1.Text);
            cmd.Parameters.AddWithValue("@Lname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.Parameters.AddWithValue("@Ethnicity",comboBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@BGroup", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox5.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBox6.Text);
            cmd.Parameters.AddWithValue("@RAdd", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";
          


            MessageBox.Show("Successfully Inserted!");
        }

        private void button2_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Patient SET FName=@FName,LName=@LName,Age=@Age,Ethnicity=@Ethnicity,Gender=@Gender,BGroup=@BGroup,Email=@Email,PhoneNumber=@PhoneNumber,RAdd=@RAdd WHERE FName=@FName ", con);
            cmd.Parameters.AddWithValue("@FName", textBox1.Text);
            cmd.Parameters.AddWithValue("@Lname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.Parameters.AddWithValue("@Ethnicity", comboBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", comboBox1.Text);
            cmd.Parameters.AddWithValue("@BGroup", comboBox3.Text);
            cmd.Parameters.AddWithValue("@Email", textBox5.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", textBox6.Text);
            cmd.Parameters.AddWithValue("@RAdd", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Successfully UPDATE!");


        }

        private void button3_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Patient WHERE FName=@FName", con);
            cmd.Parameters.AddWithValue("@FName", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            comboBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox4.Text = "";

            MessageBox.Show("Successfully DELETED!");




        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Patient", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-DJRCE3V;Initial Catalog=HOSPITAL;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Patient WHERE FName=@FName", con);
            cmd.Parameters.AddWithValue("@FName", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

           



        }
    }
}
