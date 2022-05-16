using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewDatabase
{
    public class TraineeInfo
    {
        public int TraineeID { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime DateEmployed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        
    }

    class TraineeDataClass
    {
        string connectionString = ConfigurationManager.ConnectionStrings["NewConnection"].ConnectionString;

        //to add functionality of your button, public int [Action to be performed]+[Name of your Table] ("secondary dataclass created" "custom dataclass")
        public int InsertEmployeeDetails(TraineeInfo traineeInfo)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Insert into [TableName](Properties) Values(@content)
                    String query = "INSERT INTO EmployeeDetails (TraineeID,Surname,OtherNames,Gender, MobileNo,Email,Address,DateEmployed,DateOfBirth,DateCreated) Values(@TraineeID,@Surname,@OtherNames,@Gender, @MobileNo,@Email,@Address,@DateEmployed,@DateOfBirth,@DateCreated)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TraineeID", traineeInfo.TraineeID);
                        command.Parameters.AddWithValue("@Surname", traineeInfo.Surname);
                        command.Parameters.AddWithValue("@OtherNames", traineeInfo.OtherNames);
                        command.Parameters.AddWithValue("@Gender", traineeInfo.Gender);
                        command.Parameters.AddWithValue("@MobileNo", traineeInfo.MobileNo);
                        command.Parameters.AddWithValue("@Email", traineeInfo.Email);
                        command.Parameters.AddWithValue("@Address", traineeInfo.Address);
                        command.Parameters.AddWithValue("@DateEmployed", traineeInfo.DateEmployed);
                        command.Parameters.AddWithValue("@DateOfBirth", traineeInfo.DateOfBirth);
                        command.Parameters.AddWithValue("@DateCreated", traineeInfo.DateCreated);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        else
                        { 
                            MessageBox.Show(" Trainee Record Added Successfully.");

                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            return 1;

        }

        public DataTable ReadEmployeeDetails()
        {
            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "SELECT * FROM EmployeeDetails";

                SqlCommand sqlcom = new SqlCommand(sql, connection);
                try
                {
                    sqlcom.Connection.Open();
                    sqlcom.ExecuteNonQuery();
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    datatable.Load(reader);

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return datatable;
        }


        public DataTable ReadEmployeeDetails(string TraineeID)
        {
            DataTable datatable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "SELECT * FROM EmployeeDetails where TraineeID=@TraineeID";

                SqlCommand sqlcom = new SqlCommand(sql, connection);
                try
                {
                    sqlcom.Parameters.AddWithValue("@TraineeID", TraineeID);
                    sqlcom.Connection.Open();
                    sqlcom.ExecuteNonQuery();
                    SqlDataReader reader = sqlcom.ExecuteReader();

                    datatable.Load(reader);


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

               

            }
            return datatable;
        }
        public int UpdateEmployeeDetails(TraineeInfo traineeInfo)
        {
            int result = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Insert into [TableName](Properties) Values(@content)
                    String query = "UPDATE EmployeeDetails set TraineeID=@TraineeID, Surname=@Surname, OtherNames=@OtherNames, Gender=@Gender, MobileNo=@MobileNo, Email=@Email, Address=@Address, DateEmployed=@DateEmployed, DateOfBirth=@DateOfBirth, DateUpdated=@DateUpdated where TraineeID=@TraineeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TraineeID", traineeInfo.TraineeID);
                        command.Parameters.AddWithValue("@Surname", traineeInfo.Surname);
                        command.Parameters.AddWithValue("@OtherNames", traineeInfo.OtherNames);
                        command.Parameters.AddWithValue("@Gender", traineeInfo.Gender);
                        command.Parameters.AddWithValue("@MobileNo", traineeInfo.MobileNo);
                        command.Parameters.AddWithValue("@Email", traineeInfo.Email);
                        command.Parameters.AddWithValue("@Address", traineeInfo.Address);
                        command.Parameters.AddWithValue("@DateEmployed", traineeInfo.DateEmployed);
                        command.Parameters.AddWithValue("@DateOfBirth", traineeInfo.DateOfBirth);
                        command.Parameters.AddWithValue("@DateUpdated", DateTime.Now);

                        connection.Open();
                        result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error Updating data into Database!");
                        }
                        else
                        {
                            MessageBox.Show(" Trainee Record Updated Successfully.");

                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            return result;

        }


        public int DELETEEmployeeDetails(TraineeInfo traineeInfo)
        {

            if (MessageBox.Show("Are you sure you want to Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {

                        //"Delete from [TableName] where Primary key=@Primary key"; 
                        String query = "DELETE from EmployeeDetails where TraineeID=@TraineeID";

                        using (SqlCommand command = new SqlCommand(query, connection))

                        {
                            command.Parameters.AddWithValue("@TraineeID", traineeInfo.TraineeID);
                           

                            connection.Open();
                            int result = command.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                            {
                                Console.WriteLine("Error Deleting data in Database!");
                            }
                            else
                            {
                                MessageBox.Show("Trainee Record Deleted Successfully.");
                            }
                        }
                    }


                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

                return 0;

           
        }

    }
}


