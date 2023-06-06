using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DbContext
    {
        string cs = @"server = DESKTOP-QG50OON\SQLEXPRESS;initial catalog = NewEmployee; integrated security = true";
        public List<DoctorModel> GetDoctors()
        {
            List<DoctorModel> lst = new List<DoctorModel>();

            string query = "Select * from Doctor";
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DoctorModel obj = new DoctorModel();
                obj.ID = (int)reader["ID"];
                obj.Name = (string)reader["Name"];
                obj.Speciality = (string)reader["Speciality"];
                obj.Years_of_Exp = (int)reader["Years_of_Exp"];
                obj.Gender = (string)reader["Gender"];
                lst.Add(obj);
            }
            return lst;
        }

        public bool AddDoctor(DoctorModel doctorModel)
        {
            bool value = true;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("insert_data", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Speciality", doctorModel.Speciality));
                cmd.Parameters.Add(new SqlParameter("@Name", doctorModel.Name));
                cmd.Parameters.Add(new SqlParameter("@Years_of_Exp", doctorModel.Years_of_Exp));
                cmd.Parameters.Add(new SqlParameter("@Gender", doctorModel.Gender));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return value;
        }

        public bool UpdateDoctor(DoctorModel doctorModel)
        {
            bool value = true;

            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("update_data", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", doctorModel.ID));
                cmd.Parameters.Add(new SqlParameter("@Speciality", doctorModel.Speciality));
                cmd.Parameters.Add(new SqlParameter("@Name", doctorModel.Name));
                cmd.Parameters.Add(new SqlParameter("@Years_of_Exp", doctorModel.Years_of_Exp));
                cmd.Parameters.Add(new SqlParameter("@Gender", doctorModel.Gender));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return value;
        }

        public bool Delete(string ID)
        {
            bool value = true;
            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("delete_data", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID",ID));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return value;
        }

        public void AddEmployee(EmployeeModel employeeModel)
        {
            using (SqlConnection conn = new SqlConnection(cs))
            {
                //conn.Open();
                //SqlDataAdapter da = new SqlDataAdapter("spGetStudents", connection);
                //SqlDataAdapter da = new SqlDataAdapter("usp_InsertEmployee", conn);
                SqlCommand cmd = new SqlCommand("usp_InsertEmployee", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand = new SqlCommand("usp_InsertEmployee", conn)
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("EName", employeeModel.EmployeeName));
                cmd.Parameters.Add(new SqlParameter("ENo", employeeModel.EmployeeID));
               cmd.Parameters.Add(new SqlParameter("EPhone", employeeModel.EmployeeContact));

                cmd.Parameters.Add(new SqlParameter("EDOB", employeeModel.DOB));
                cmd.Parameters.Add(new SqlParameter("EAddress", employeeModel.EmployeeAdress));
                conn.Open();
               cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<EmployeeModel> SearchEmployeeByName(string name)
        {
            List<EmployeeModel> lst = new List<EmployeeModel>();
            using (SqlConnection conn = new SqlConnection(cs))
            {

               
                SqlCommand cmd = new SqlCommand("SearchEmployee",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("EmpName", name));
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for(int i=0;i<dt.Rows.Count;i++ )
                {
                    EmployeeModel employeeModel = new EmployeeModel();
                    employeeModel.EmployeeID = int.Parse(dt.Rows[i]["EmpID"].ToString());
                    employeeModel.EmployeeName = dt.Rows[i]["EmpName"].ToString();
                    employeeModel.EmployeeAdress = dt.Rows[i]["EmpAddress"].ToString();
                    employeeModel.EmployeeContact = dt.Rows[i]["EmpPhone"].ToString();
                    employeeModel.DOB= DateTime.Parse(dt.Rows[i]["EmpDOB"].ToString());
                    employeeModel.Status= dt.Rows[i]["EmpStatus"].ToString();
                    lst.Add(employeeModel);
                }
                
            }
            return lst;
        }

        public List<EmployeeModel> GetEmployee()
        {
            List<EmployeeModel> lst = new List<EmployeeModel>();

            using (SqlConnection conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SearchEmployeeAll", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {


                    EmployeeModel employeeModel = new EmployeeModel();
                    employeeModel.EmployeeID = int.Parse(dt.Rows[i]["EmpID"].ToString());
                    employeeModel.EmployeeName = dt.Rows[i]["EmpName"].ToString();
                    employeeModel.EmployeeAdress = dt.Rows[i]["EmpAddress"].ToString();
                    employeeModel.EmployeeContact = dt.Rows[i]["EmpPhone"].ToString();
                    employeeModel.DOB = DateTime.Parse(dt.Rows[i]["EmpDOB"].ToString());
                    
                    lst.Add(employeeModel);
                }
            }
            return lst;
        }

    }
}
