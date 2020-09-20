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

namespace FinalProject
{
    public partial class Manage_Users : MetroFramework.Forms.MetroForm
    {
        public Manage_Users()
        {
            InitializeComponent();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user_details user_Details = new user_details();
            user_Details.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Niro Strak\NSBM works\2nd Sem\C#\FINAL C# PROJECT\FinalProject\DB.mdf';Integrated Security=True;Connect Timeout=30");

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            string nic = txtNIC.Text,
                   name = txtName.Text,
                   username = txtUname.Text,
                   email = txtEmail.Text,
                   password = txtPassword.Text,
                   confirmPassword = txtConfirmPassword.Text;
            
            string address = txtAddress.Text;
            int phoneNumber = int.Parse(txtPhoneNumber.Text);

            if (txtNIC.Text == "" && txtPhoneNumber.Text == "")
            {
                MessageBox.Show("NIC or Phone Number is required!");
            }
            else
            {
                string qry = "Update userdetails Set Name='" + name + "' Uname = '"+username+"' Email = '"+email+"' Password = '"+password+"' ConfirmPassword = '"+confirmPassword+"' Address = '"+address+"' PhoneNumber = '"+phoneNumber+"' where NIC ='" + nic + "' or PhoneNumber='" + phoneNumber + "'";
                SqlCommand cmd = new SqlCommand(qry,con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated successfully!");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string nic = txtNIC.Text;

            string qry = "Delete * from userdetails Where NIC = '" + nic+"' ";
            SqlCommand cmd = new SqlCommand(qry, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted successfully!");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("" + sqlex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNIC.Text = null;
            txtName.Text = null;
            txtUname.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            txtConfirmPassword.Text = null;
            txtConfirmPassword.Text = null;
            txtAge.Text = null;
            txtAddress.Text = null;
            txtPhoneNumber = null;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
    }
}
