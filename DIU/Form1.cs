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
using MySql.Data.MySqlClient;

namespace DIU
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection = new MySqlConnection();
        private string connectionString = "server=localhost;user id=root;persistsecurityinfo=True;database=crud;password=1110188516aA*";
        private MySqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void greet_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            MessageBox.Show("Hello " + name_tb.Text);
        }

        public void retrive()
        {
            connection.ConnectionString = connectionString;
            cmd = connection.CreateCommand();

            try
            {

                string query = "select * from crudtable";


                cmd.CommandText = query;
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);

                dataGridView1.DataSource = dt;

                reader.Close();


            }
            catch (Exception e1)
            {
                string msg = e1.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                connection.Close();
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            retrive();
        }
        

        private void save_btn_Click(object sender, EventArgs e)
        {
            {

                string id = sid_tb.Text;
                string name = name_tb.Text;
                string email = email_tb.Text;

                if ((id == "") || (name == "") || (email == ""))
                {
                    string msg = "No textbox can be empty";
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.ConnectionString = connectionString;
                    cmd = connection.CreateCommand();

                    try
                    {

                        string query = "Insert into crudtable values('"
                            + id + "','"
                            + name + "','"
                            + email + "')";


                        cmd.CommandText = query;
                        connection.Open();
                        cmd.ExecuteScalar();


                    }
                    catch (Exception e1)
                    {
                        string msg = e1.Message.ToString();
                        string caption = "Error";
                        MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        cmd.Dispose();
                        connection.Close();
                        retrive();
                    }
                }
            }
        }

        public void updateName()
        {
            connection.ConnectionString = connectionString;
            cmd = connection.CreateCommand();

            try
            {

                string query = "UPDATE crudtable SET \"name\" = '"+name_tb.Text+"' WHERE \"sid\" = "+sid_tb.Text;


                cmd.CommandText = query;
                connection.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception e1)
            {
                string msg = e1.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                connection.Close();
                retrive();
            }
        }

        public void updateEmail()
        {
            connection.ConnectionString = connectionString;
            cmd = connection.CreateCommand();

            try
            {

                string query = "UPDATE crudtable SET \"email\" = '" + email_tb.Text + "' WHERE \"sid\" = " + sid_tb.Text;
                
                cmd.CommandText = query;
                connection.Open();
                cmd.ExecuteScalar();


            }
            catch (Exception e1)
            {
                string msg = e1.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                connection.Close();
                retrive();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            connection.ConnectionString = connectionString;
            cmd = connection.CreateCommand();

            try
            {
                string query = "select * from crudtable";
                cmd.CommandText = query;
                connection.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                reader.Close();

            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                connection.Close();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (sid_tb.Text != "")
            {
                if (name_tb.Text != "")
                {
                    updateName();
                    MessageBox.Show("Name Change Successful!");
                }
                else
                {
                    MessageBox.Show("Name field is empty! Name was not changed!");
                }

                if (email_tb.Text != "")
                {
                    updateEmail();
                    MessageBox.Show("Email Change Successful!");
                }
                else
                {
                    MessageBox.Show("Email field is empty! Email was not changed!");
                }
            }
            else
            {
               MessageBox.Show("Student ID Can't be empty!");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (sid_tb.Text != "")
            {
                connection.ConnectionString = connectionString;
                cmd = connection.CreateCommand();

                try
                {

                    string query = "DELETE FROM crudtable WHERE sid = " + sid_tb.Text;

                    cmd.CommandText = query;
                    connection.Open();
                    cmd.ExecuteScalar();


                }
                catch (Exception e1)
                {
                    string msg = e1.Message.ToString();
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                    retrive();
                }
            }
            else
            {
                MessageBox.Show("Could not delete! Student ID was empty!");
            }
            
        }
    }
}
