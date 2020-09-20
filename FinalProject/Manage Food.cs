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
    public partial class Manage_Food : MetroFramework.Forms.MetroForm
    {
        public Manage_Food()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {

        }

        private void btnManageFood_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Niro Strak\NSBM works\2nd Sem\C#\FINAL C# PROJECT\FinalProject\DB.mdf';Integrated Security=True;Connect Timeout=30");
        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtPrice.Text = null;


        }
        
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtPrice.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {/*
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {/*
            user_details user_Details = new user_details();
            user_Details.Show();
            this.Hide();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {/*
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();*/
        }

        private void button5_Click(object sender, EventArgs e)
        {/*
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();*/
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            user_details user_Details = new user_details();
            user_Details.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();
        }

       
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            int foodID = int.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            double price = double.Parse(txtPrice.Text);

            if (txtFoodName.Text == "" || txtFoodID.Text == null && !(txtPrice.Text == ""))
            {

                string qry = "Update Food Set price='" + price + "' where foodID='" + foodID + "' or Name='" + name + "'";
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
            else
            {
                MessageBox.Show("Fillout Required Fields!");
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (txtFoodID.Text == "")
            {
                MessageBox.Show("Food ID is required");
            }
            else
            {
                int foodID = int.Parse(txtFoodID.Text);
                string qry = "Delete from Food where FoodID = '" + foodID + "' ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully!");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Offer_Details offer_Details = new Offer_Details();
            offer_Details.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }
    }
}
