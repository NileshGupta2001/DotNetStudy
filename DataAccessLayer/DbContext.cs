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
        string cs = @"server = DESKTOP-QG50OON\SQLEXPRESS;initial catalog = Doctor; integrated security = true";
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

    }
}
