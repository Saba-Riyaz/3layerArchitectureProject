using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CampusDBAccess
    {
        SqlConnection Con = new SqlConnection("Data Source=CGPC17\\SQLEXPRESS;Initial Catalog=Campus;Integrated Security=True");

        public CampusDBAccess ()
        {


        }
        public void SaveCampus (CampusEntity campusentity )
        {

            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "Execute spInsertCampus @CampusName,@CampusAddress,@CampusEmail,@CampusWebsite";

            cmd.Parameters.Add("@CampusName", SqlDbType.VarChar, 50).Value = campusentity.CampusName;
            cmd.Parameters.Add("@CampusAddress", SqlDbType.VarChar, int.MaxValue).Value = campusentity.CampusAddress;
            cmd.Parameters.Add("@CampusEmail", SqlDbType.VarChar, 50).Value = campusentity.CampusEmail;
            cmd.Parameters.Add("@CampusWebsite", SqlDbType.VarChar, int.MaxValue).Value = campusentity.CampusWebsite;
           


            Con.Open();

            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Record Inserted SuccessFully");




        }

        public DataTable GetCampus ()
        {
            SqlCommand cmd = new SqlCommand("spshowData", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public void UpdateCompany(CampusEntity campusentity )
        {
            SqlCommand cmd = new SqlCommand("spUpdateData", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@CampusName", SqlDbType.VarChar, 50).Value = campusentity.CampusName;
            cmd.Parameters.Add("@CampusAddress", SqlDbType.VarChar, int.MaxValue).Value = campusentity.CampusAddress;
            cmd.Parameters.Add("@CampusEmail", SqlDbType.VarChar, 50).Value = campusentity.CampusEmail;
            cmd.Parameters.Add("@CampusWebsite", SqlDbType.VarChar, int.MaxValue).Value = campusentity.CampusWebsite;

            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Updated Successfully");
        }


        public void DeleteCampus (int CampusId )
        {
            // Create a new SqlCommand object for the stored procedure
            SqlCommand cmd = new SqlCommand("spDeleteData", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the parameters for the stored procedure
            cmd.Parameters.AddWithValue("@CampusId", CampusId);




            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }

        public void UpdateCampus(CampusEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

