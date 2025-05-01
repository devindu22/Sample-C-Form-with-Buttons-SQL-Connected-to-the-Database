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

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection abc = new SqlConnection(@"Data Source=DESKTOP-SSNOE6V\SQLEXPRESS;Initial Catalog=project;Integrated Security=True");
        string gender;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectDataSet.student);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            male.Checked = false;
            female.Checked = false;
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int st_Id = int.Parse(textBox1.Text);
                string st_name = textBox2.Text;
                string dob = textBox3.Text;
                string st_address = textBox4.Text;
                string contactNo = textBox5.Text;

                string insert = "INSERT INTO student values(" + st_Id + ",'" + st_name + "','" + dob + "','" + gender + "','" + st_address + "','" + contactNo + "')";
                SqlCommand cmd = new SqlCommand(insert, abc);
                abc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                abc.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int st_Id = int.Parse(textBox1.Text);
                string search = "SELECT * FROM student WHERE st_Id = "+st_Id+"";
                SqlCommand cmd = new SqlCommand(search, abc);
                SqlDataReader rd;
                abc.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    textBox2.Text = rd[1].ToString();
                    textBox3.Text = rd[2].ToString();
                    gender = rd[3].ToString();
                    if (gender == "Male")
                    {
                        male.Checked = true;
                    }
                    else
                    {
                        female.Checked = false;
                    }
                    textBox4.Text = rd[4].ToString();
                    textBox5.Text = rd[5].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                abc.Close();
            }

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int st_Id = int.Parse(textBox1.Text);
                string st_name = textBox2.Text;
                string dob = textBox3.Text;
                string st_address = textBox4.Text;
                string contactNo = textBox5.Text;

                string update = "UPDATE student SET st_name='" + st_name + "',dob='" + dob + "',gender='" + gender + "',st_address='" + st_address + "',contactNo='" + contactNo + "' WHERE st_Id = "+st_Id+"";
                SqlCommand cmd = new SqlCommand(update, abc);
                abc.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                abc.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                abc.Open();
                int st_Id = int.Parse(textBox1.Text);
                string delete = "DELETE FROM student WHERE st_Id =" + st_Id + "";
                SqlCommand cmd = new SqlCommand(delete, abc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                abc.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                abc.Open();
                string view = "SELECT * FROM student";
                SqlDataAdapter da = new SqlDataAdapter(view, abc);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex);
            }
            finally
            {
                abc.Close();
            }
        }
    }
}
