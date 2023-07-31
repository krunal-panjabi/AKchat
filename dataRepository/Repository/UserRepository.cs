using dataRepository.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataRepository.Repository
{
    public class UserRepository : IUserRepository
    {
        public string connections = "server=192.168.2.59\\SQL2019;Database=AKchat;User Id=sa;Password=Tatva@123;Encrypt=False";


        public int registerrepo(UserVM model)
        {
            using (SqlConnection con = new SqlConnection(connections))
            {
                SqlCommand cmd = new SqlCommand("spInsertComapny", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", model.companyName);
                cmd.Parameters.AddWithValue("@companyCode", model.companyCode);
                cmd.Parameters.AddWithValue("@password", model.password);
                con.Open();

                int i = cmd.ExecuteNonQuery();

                return i;
            }
        }
    }
}
