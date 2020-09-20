using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Admin_Dashboard : MetroFramework.Forms.MetroForm
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user_details user_Details = new user_details();
            user_Details.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();
        }

        private void btnFoodDetails_Click(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void btnManageOffers_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnOfferDetails_Click(object sender, EventArgs e)
        {
            Offer_Details offer_Details = new Offer_Details();
            offer_Details.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }
    }
}
