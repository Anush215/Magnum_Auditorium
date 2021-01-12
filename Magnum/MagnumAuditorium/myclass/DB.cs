using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace MagnumAuditorium.myclass
{
    class DB
    {
        public MySqlConnection con;

        public DB()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=dev;password=123;database=magnum;convert zero datetime=True";
            con = new MySqlConnection(connectionString);

        }
    }
    class FacilitiesCRUD : DB
        {
            //PROPERTIES
            public string FacilityName { set; get; }
            public string FacilityType { set; get; }

            //READ PROPORTIES
            public DataTable FacilitiesDT = new DataTable();
            private DataSet FacilitiesDS = new DataSet();

            //FacilitiesID
            public string FacilityID { set; get; }

            //FACILITY CREATE FUNCTION
            public void Create()
            {

            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO `facility` (`FacilityName` , `FacilityType`) VALUES(@FacilityName, @FacilityType) ";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@FacilityName", MySqlDbType.VarChar).Value = FacilityName;
                    cmd.Parameters.Add("@FacilityType", MySqlDbType.VarChar).Value = FacilityType;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added facility");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

            //FACILITY UPDATE FUNCTION
            public void Update()
            {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE facility SET FacilityName=@FacilityName, FacilityType=@FacilityType WHERE FacilityID=@FacilityID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@FacilityName", MySqlDbType.VarChar).Value = FacilityName;
                    cmd.Parameters.Add("@FacilityType", MySqlDbType.VarChar).Value = FacilityType;

                    cmd.Parameters.Add("@FacilityID", MySqlDbType.Int32).Value = FacilityID;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated  facility");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

            //FACILITY DELETE FUNCTION
            public void Delete()
            {
            try { 
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM facility WHERE FacilityID=@FacilityID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@FacilityID", MySqlDbType.Int32).Value = FacilityID;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted facility");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

            //FACILITY READ FUNCTION
            public void Read()
            {
                FacilitiesDS.Clear();
                string query = "SELECT * FROM `facility`";
                MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
                MDA.Fill(FacilitiesDS);
                FacilitiesDT = FacilitiesDS.Tables[0];
            }
        }


    class ResourcesCRUD : DB
    {
        //PROPERTIES
        public int FacilityID { set; get; }
        public string ResourceName { set; get; }
        public int ResourceQty { set; get; }

        //READ PROPORTIES
        public DataTable ResourcesDT = new DataTable();
        private DataSet ResourcesDS = new DataSet();

        //ResourceID
        public string ResourceID { set; get; }

        //RESOURCE CREATE FUNCTION
        public void Create()
        {

            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "INSERT INTO `resource` (`FacilityID`, `ResourceName`, `ResourceQty`)  VALUES(@FacilityID, @ResourceName, @ResourceQty) ";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@FacilityID", MySqlDbType.Int32).Value = FacilityID;
                    cmd.Parameters.Add("@ResourceName", MySqlDbType.VarChar).Value = ResourceName;
                    cmd.Parameters.Add("@ResourceQty", MySqlDbType.Int32).Value = ResourceQty;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added resource");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        //RESOURCE UPDATE FUNCTION
        public void Update()
        {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE resource SET  ResourceName=@ResourceName, ResourceQty=@ResourceQty WHERE ResourceID=@ResourceID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

              
                    cmd.Parameters.Add("@ResourceName", MySqlDbType.VarChar).Value = ResourceName;
                    cmd.Parameters.Add("@ResourceQty", MySqlDbType.Int32).Value = ResourceQty;

                    cmd.Parameters.Add("@ResourceID", MySqlDbType.Int32).Value = ResourceID;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated resource");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        //RESOURCE DELETE FUNCTION
        public void Delete()
        {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    
                    cmd.CommandText = "DELETE FROM resource WHERE ResourceID=@ResourceID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@ResourceID", MySqlDbType.Int32).Value = ResourceID;
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted resource");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            con.Close();
        }

        //RESOURCE READ FUNCTION
        public void Read()
        {
            ResourcesDS.Clear();
            string query = "SELECT * FROM `resource`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ResourcesDS);
            ResourcesDT = ResourcesDS.Tables[0];
        }

    }

    class ReservationsCRUD : DB
    {
        //PROPERTIES
        public int FacilityID { set; get; }
        public int PartnerID { set; get; }
        public string CustomerName { set; get; }
        public string  CustomerContact { set; get; }
        public string ReserveFunction { set; get; }
        public string ReserveFrom { set; get; }
        public string ReserveTo { set; get; }

        //READ PROPORTIES
        public DataTable ReservationsDT = new DataTable();
        private DataSet ReservationsDS = new DataSet();

        //ReservationID
        public string ReserveID { set; get; }

        //RESERVATION CREATE FUNCTION
        public void CreateCode()
        {

           try
            {
                               
                
                
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "INSERT INTO `reservation` (`FacilityID`,`PartnerID`, `CustomerName`, `CustomerContact`, `ReserveFunction`, `ReserveFrom`, `ReserveTo`) VALUES (@FacilityID, @PartnerID, @CustomerName, @CustomerContact, @ReserveFunction, @ReserveFrom, @ReserveTo)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    if(PartnerID > 1)
                    {
                        cmd.Parameters.Add("@PartnerID", MySqlDbType.Int32).Value = PartnerID;
                    }
                    else
                    {
                        cmd.Parameters.Add("@PartnerID", MySqlDbType.Int32).Value = null;
                    }

                    cmd.Parameters.Add("@FacilityID", MySqlDbType.Int32).Value = FacilityID;
                    cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = CustomerName;
                    cmd.Parameters.Add("@CustomerContact", MySqlDbType.VarChar).Value = CustomerContact;
                    cmd.Parameters.Add("@ReserveFunction", MySqlDbType.VarChar).Value = ReserveFunction;
                    cmd.Parameters.Add("@ReserveFrom", MySqlDbType.VarChar).Value = ReserveFrom;
                    cmd.Parameters.Add("@ReserveTo", MySqlDbType.VarChar).Value = ReserveTo;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added reservation");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        // RESERVATION AVOID OVERLAP FUNCTION
        public void Create()
        {
            con.Open();
            using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;username=dev;password=123;database=magnum;"))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT * FROM reservation WHERE FacilityID = @FacilityID && ReserveFrom < @ReserveTo && @ReserveFrom < ReserveTo";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@FacilityID", MySqlDbType.Int32).Value = FacilityID;
                    cmd.Parameters.Add("@ReserveFrom", MySqlDbType.VarChar).Value = ReserveFrom;
                    cmd.Parameters.Add("@ReserveTo", MySqlDbType.VarChar).Value = ReserveTo;
                    
                    var dr = cmd.ExecuteReader();
                    
                  
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Facility is not available at the time you selected");
                    }

                    else
                    {
                        dr.Close();

                        CreateCode();
                    }
                    con.Close();
                    




                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Error occured!" + ex);
                }
            }

        }

        //RESERVATION UPDATE FUNCTION
        public void Update()
        {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE reservation SET  CustomerName=@CustomerName, CustomerContact=@CustomerContact, ReserveFunction=@ReserveFunction, ReserveFrom=@ReserveFrom, ReserveTo=@ReserveTo WHERE ReserveID=@ReserveID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;


                  
                    cmd.Parameters.Add("@CustomerName", MySqlDbType.VarChar).Value = CustomerName;
                    cmd.Parameters.Add("@CustomerContact", MySqlDbType.VarChar).Value = CustomerContact;
                    cmd.Parameters.Add("@ReserveFunction", MySqlDbType.VarChar).Value = ReserveFunction;
                    cmd.Parameters.Add("@ReserveFrom", MySqlDbType.VarChar).Value = ReserveFrom;
                    cmd.Parameters.Add("@ReserveTo", MySqlDbType.VarChar).Value = ReserveTo;

                    cmd.Parameters.Add("@ReserveID", MySqlDbType.Int32).Value = ReserveID;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated reservation");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        //RESERVATION DELETE FUNCTION
        public void Delete()
        {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "DELETE FROM reservation WHERE ReserveID=@ReserveID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@ReserveID", MySqlDbType.Int32).Value = ReserveID;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted reservation");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            con.Close();
        }

        //RESERVATION READ FUNCTION
        public void Read()
        {
            ReservationsDS.Clear();
            string query = "SELECT * FROM `reservation`";
            MySqlDataAdapter MDA = new MySqlDataAdapter(query, con);
            MDA.Fill(ReservationsDS);
            ReservationsDT = ReservationsDS.Tables[0];
        }

    }

    class PartnersCRUD : DB
    {
        //PROPERTIES
        
        public string PartnerName { set; get; }
        public string PartnerContact { set; get; }
        
       
        //PartnersID
        public int PartnerID { set; get; }

        //PARTNER CREATE FUNCTION
        public void Create()
        {

            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "INSERT INTO `partner` (`PartnerName`, `PartnerContact`) VALUES (@PartnerName, @PartnerContact)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                   
                    cmd.Parameters.Add("@PartnerName", MySqlDbType.VarChar).Value = PartnerName;
                    cmd.Parameters.Add("@PartnerContact", MySqlDbType.VarChar).Value = PartnerContact;
                    

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully added partner");
                    con.Close();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }

        //DELETE FUNCTION
        public void Delete()
        {
            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {

                    cmd.CommandText = "DELETE FROM partner WHERE PartnerID=@PartnerID";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    cmd.Parameters.Add("@PartnerID", MySqlDbType.Int32).Value = PartnerID;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully deleted partner");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            con.Close();
        }

        
    }

}
