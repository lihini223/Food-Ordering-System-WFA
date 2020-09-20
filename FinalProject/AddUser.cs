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

namespace FinalProject
{
    public partial class AddUser : MetroFramework.Forms.MetroForm
    {
        string ValueOfCombo;
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nic = txtNIC.Text,
                   name = txtName.Text,
                   username = txtUname.Text,
                   email = txtEmail.Text,
                   password = txtPassword.Text,
                   confirmPassword = txtConfirmPassword.Text;

            
 int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            int phoneNumber = int.Parse(txtPhoneNumber.Text);
          
            if (txtNIC.Text == "" || txtName.Text == "" || txtUname.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" || ValueOfCombo == null)
            {
                MessageBox.Show("Fillout Required Fields!");
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Niro Strak\NSBM works\2nd Sem\C#\FINAL C# PROJECT\FinalProject\DB.mdf';Integrated Security=True;Connect Timeout=30");
                    string qry = "Insert Into userdetails Values('" + nic+"','"+name+"','"+username+"','"+email+"','"+password+"','"+confirmPassword+"','"+age+"','"+address+"','"+phoneNumber+ "','" + ValueOfCombo + "')";
                    SqlCommand cmd = new SqlCommand(qry,con);
                    //
                    //

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Inserted Successfully!");
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show("" + sqlex);
                    }
                }
                else
                {
                    MessageBox.Show("Confirm Password is not matching!");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
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
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Offer_Details offer_Details = new Offer_Details();
            offer_Details.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNIC.Text = null;
            txtName.Text = null;
            txtUname.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            txtConfirmPassword.Text = null;
            txtAge.Text = null;
            txtAddress.Text = null;
            txtPhoneNumber.Text = null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
           ValueOfCombo = cmbType.Text;
        }
    }
}
