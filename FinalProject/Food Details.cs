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
    public partial class Food_Details : MetroFramework.Forms.MetroForm
    {
        public Food_Details()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void dgvFoodDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
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

        private void button9_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }
        
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Niro Strak\NSBM works\2nd Sem\C#\FINAL C# PROJECT\FinalProject\DB.mdf';Integrated Security=True;Connect Timeout=30";

        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM Food ";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "Food");
            dgvFoodDetails.DataSource = DS.Tables["Food"];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int foodid = int.Parse(txtFoodID.Text);
            string foodname = txtFoodName.Text;
            string qry = "SELECT * FROM Food where foodID = '"+foodid+"' or Name = '"+foodname+"'";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "Food");
            dgvFoodDetails.DataSource = DS.Tables["Food"];
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
    }
}
