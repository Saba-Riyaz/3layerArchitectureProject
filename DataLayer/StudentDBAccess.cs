using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer
{
    public class StudentDBAccess
    {
        SqlConnection Con = new SqlConnection("Data Source = CGPC17\\SQLEXPRESS; Initial Catalog = Company; Integrated Security = True");

        public StudentDBAccess ()
        {


        }
        public void SaveEmployee(StudentEntity studententity )
        {

            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandText = "Execute spInsertStudent @FirstName , @LastName, @Email, @Phone, @Address , @DateOfBirth, @Gender , @Age, @Religion";

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = studententity.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = studententity.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studententity.Email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, int.MaxValue).Value = studententity.Phone;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, int.MaxValue).Value = studententity.Address;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.VarChar, int.MaxValue).Value = studententity.DateOfBirth;
            cmd.Parameters.Add("@Gender ", SqlDbType.VarChar, int.MaxValue).Value = studententity.Gender;
            cmd.Parameters.Add("@Age ", SqlDbType.VarChar, int.MaxValue).Value = studententity.Age;
            cmd.Parameters.Add("@Religion  ", SqlDbType.VarChar, int.MaxValue).Value = studententity.Religion;


            Con.Open();

            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Record Inserted SuccessFully");




        }

        public DataTable GetStudent ()
        {
            SqlCommand cmd = new SqlCommand("spshowStudent", Con);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }

        public void UpdateStudent (StudentEntity studententity )
        {
            SqlCommand cmd = new SqlCommand("spUpdateStudent", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = studententity.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = studententity.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = studententity.Email;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar, int.MaxValue).Value = studententity.Phone;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar, int.MaxValue).Value = studententity.Address;
            cmd.Parameters.Add("@DateOfBirth", SqlDbType.VarChar, int.MaxValue).Value = studententity.DateOfBirth;
            cmd.Parameters.Add("@Gender ", SqlDbType.VarChar, int.MaxValue).Value = studententity.Gender;
            cmd.Parameters.Add("@Age ", SqlDbType.VarChar, int.MaxValue).Value = studententity.Age;
            cmd.Parameters.Add("@Religion  ", SqlDbType.VarChar, int.MaxValue).Value = studententity.Religion;

            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Updated Successfully");
        }


        public void DeleteStudent (int StudentId )
        {
            // Create a new SqlCommand object for the stored procedure
            SqlCommand cmd = new SqlCommand("spDeleteStudent", Con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the parameters for the stored procedure
            cmd.Parameters.AddWithValue("@StudentId", StudentId);




            Con.Open();

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Record Deleted Successfully");
        }

        public void SaveStudent(StudentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

