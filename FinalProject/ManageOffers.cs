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
    public partial class ManageOffers : MetroFramework.Forms.MetroForm
    {
        public ManageOffers()
        {
            InitializeComponent();
        }

        private void ManageOffers_Load(object sender, EventArgs e)
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
            Offer_Details offer_Details = new Offer_Details();
            offer_Details.Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\Niro Strak\NSBM works\2nd Sem\C#\FINAL C# PROJECT\FinalProject\DB.mdf';Integrated Security=True;Connect Timeout=30");

        private void button10_Click(object sender, EventArgs e)
        {
            int offerID = int.Parse(txtOfferID.Text);
            string offerName = txtOfferName.Text;
            double price = Double.Parse(txtPrice.Text);

            if (txtOfferID.Text == "" || txtOfferName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Fillout required fields");
            }
            else
            {
                string qry = "Insert Into offers values('" + offerID + "','" + offerName + "','" + price + "')";
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
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int offerID = int.Parse(txtOfferID.Text);
            string offerName = txtOfferName.Text;
            double price = Double.Parse(txtPrice.Text);

            if (txtOfferID.Text == "" || txtOfferName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Fillout required fields");
            }
            else
            {
                string qry = "Update offers Set price = '"+price+"' Where OfferID = '"+offerID+"' or OfferName = '"+offerName+"' ";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int offerID = int.Parse(txtOfferID.Text);
            string offerName = txtOfferName.Text;
           
            if (txtOfferID.Text == "" || txtOfferName.Text == "" )
            {
                MessageBox.Show("Fillout required fields");
            }
            else
            {
                string qry = "Delete * from offers Where OfferID = '"+offerID+"' or OfferName = '"+offerName+"' ";
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
            txtOfferID.Text = null;
            txtOfferName.Text = null;
            txtPrice = null;
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

        private void button9_Click(object sender, EventArgs e)
        {
            welcome Wlcm = new welcome();
            Wlcm.Show();
            this.Hide();
        }
    }
}
