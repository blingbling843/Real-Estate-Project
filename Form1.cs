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

namespace Realestate
{
    public partial class Form1 : Form
    {
        System.Data.SqlClient.SqlConnection con; // Connect to database
        public Form1()
        {
            InitializeComponent();
        }

        private void Buy(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\properties.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();

                if (garage.Text == "Yes")
                {
                    garage.Text = "1";
                }
                else if (garage.Text == "No")
                {
                    garage.Text = "0";
                }


                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id,Price FROM [Table01] where 1=1" +
                     "And (Price >= '" + Minprice.Text + "' OR '" + Minprice.Text + "' =' ')" +
                     "And (Price <= '" + Maxprice.Text + "'OR'" + Maxprice.Text + "'=' ')" +
                     "And (Bedrooms >='" + Minbed.Text + "'OR'" + Minbed.Text + "' =' ')" +
                     "And (Bedrooms <='" + Maxbed.Text + "'OR'" + Maxbed.Text + "' =' ')" +
                     "And (Isparking ='" + garage.Text + "'OR'" + garage.Text + "' =' ')" +
                     "And (Bathrooms >= '" + bathroom.Text + "'OR'" + bathroom.Text + "'=' ')" +
                     "And (LotSize >= '" + Minlot.Text + "'OR '" + Minlot.Text + "' =' ')" +
                     "And (Zipcode = '" + zipcode.Text + "'OR'" + zipcode.Text + "' =' ')" +
                     "And (HouseType ='" + type.Text + "'OR'" + type.Text + "' =' ')" +
                     "And (Action ='Buy')", con); //Search properties base on value user enter.



                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.DefaultView.Sort = "Price";
                dt = dt.DefaultView.ToTable();
                dataGridView1.DataSource = dt;
                con.Close();
            
        }

        private void Rent(object sender, EventArgs e)
        {

            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\properties.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();

                if (garage.Text == "Yes")
                {
                    garage.Text = "1";
                }
                else if (garage.Text == "No")
                {
                    garage.Text = "0";
                }

                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id,Price FROM [Table01] where 1=1" +

                     "And (Price >= '" + Minprice.Text + "' OR '" + Minprice.Text + "' =' ')" +
                     "And (Price <= '" + Maxprice.Text + "'OR'" + Maxprice.Text + "'=' ')" +

                     "And (Bedrooms >='" + Minbed.Text + "'OR'" + Minbed.Text + "' =' ')" +
                     "And (Bedrooms <='" + Maxbed.Text + "'OR'" + Maxbed.Text + "' =' ')" +
                     "And (Isparking ='" + garage.Text + "'OR'" + garage.Text + "' =' ')" +
                     "And (Bathrooms >= '" + bathroom.Text + "'OR'" + bathroom.Text + "'=' ')" +
                     "And (LotSize >= '" + Minlot.Text + "'OR '" + Minlot.Text + "' =' ')" +
                     "And (Zipcode = '" + zipcode.Text + "'OR'" + zipcode.Text + "' =' ')" +
                     "And (HouseType ='" + type.Text + "'OR'" + type.Text + "' =' ')" +
                     "And (Action ='Rent')", con); //Search properties between two range.
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dt.DefaultView.Sort = "Price";
                dt = dt.DefaultView.ToTable();
                dataGridView1.DataSource = dt;
                con.Close();
            
        }

        private void Detail_button(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\properties.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();

            String sqlSelectQuery = "SELECT * FROM [Table01] WHERE ID =" + int.Parse(Id_Detail.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                actionTextBox.Text = (dr["Action"].ToString());
                idTextBox.Text = (dr["Id"].ToString());
                houseTypeTextBox.Text = (dr["HouseType"].ToString());
                priceTextBox.Text = (dr["Price"].ToString());
                squareFootageTextBox.Text = (dr["SquareFootage"].ToString());
                lotSizeTextBox.Text = (dr["LotSize"].ToString());
                bedroomsTextBox.Text = (dr["Bedrooms"].ToString());
                bathroomsTextBox.Text = (dr["Bathrooms"].ToString());
                descriptionTextBox.Text = (dr["Description"].ToString());
                ageTextBox.Text = (dr["Age"].ToString());
                applianceTextBox.Text = (dr["Appliance"].ToString());
                isBasementCheckBox.Checked = (bool)dr["IsBasement"];
                isParkingCheckBox.Checked = (bool)(dr["IsParking"]);
                streetTextBox.Text = (dr["Street"].ToString());
                boroughTextBox.Text = (dr["Borough"].ToString());
                cityTextBox.Text = (dr["City"].ToString());
                zipcodeTextBox.Text = (dr["Zipcode"].ToString());
                countryTextBox.Text = (dr["Country"].ToString());
                nameAgentTextBox.Text = (dr["NameAgent"].ToString());
                commentAgentTextBox.Text = (dr["CommentAgent"].ToString());
                statusPropertiesTextBox.Text = (dr["StatusProperties"].ToString());
                nameOwnerTextBox.Text = (dr["NameOwner"].ToString());
                addressOwnerTextBox.Text = (dr["AddressOwner"].ToString());
                requestOwnerTextBox.Text = (dr["RequestOwner"].ToString());
                inforOwnerTextBox.Text = (dr["InforOwner"].ToString());

                con.Close();
            }

        }

        private void Offer_Detail_Click(object sender, EventArgs e)
        {
            if (Password.Text == "123456")
            {
                con = new System.Data.SqlClient.SqlConnection();
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\properties.mdf;Integrated Security=True;Connect Timeout=30";
                con.Open();

                String sqlSelectQuery = "SELECT * FROM [Table01] WHERE ID =" + int.Parse(Id_Detail.Text);
                SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    offerTextBox.Text = (dr["Offer"].ToString());
                    offerMakerTextBox.Text = (dr["OfferMaker"].ToString());
                    offerConditionTextBox.Text = (dr["OfferCondition"].ToString());
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password");

                con.Close();
            }
        }
    }
}
