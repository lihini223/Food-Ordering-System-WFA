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
    public partial class Add_food : MetroFramework.Forms.MetroForm
    {
        public Add_food()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {
            Manage_Food mngFood = new Manage_Food();
            mngFood.Show();
            this.Hide();
        }

        private void Add_food_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int foodID = int.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            double price = double.Parse(txtPrice.Text);

            if (txtFoodID.Text == "" || txtFoodName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Fillout required fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Niro Strak\NSBM works\2nd Sem\C#\FINAL C# PROJECT\FinalProject\DB.mdf';Integrated Security=True;Connect Timeout=30");
                string qry = "Insert Into Food values('" + foodID + "','" + name + "','" + price + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtPrice.Text = null;
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

        private void btnuserdetails_Click(object sender, EventArgs e)
        {
            user_details user_Details = new user_details();
            user_Details.Show();
            this.Hide();
        }

        private void btnaddfood_Click(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void btnmanagefood_Click_1(object sender, EventArgs e)
        {
            Manage_Food mngFood = new Manage_Food();
            mngFood.Show();
            this.Hide();
        }

        private void btnfooddetails_Click(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void btnmanageoffers_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }

        private void btnofferdetails_Click(object sender, EventArgs e)
        {
            Offer_Details offer_Details = new Offer_Details();
            offer_Details.Show();
            this.Show();
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
    }
}
