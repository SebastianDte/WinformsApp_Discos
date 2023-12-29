using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace business
{
    internal class DataAccess
    {
        private SqlConnection Connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public DataAccess()
        {
            Connection = new SqlConnection("server=.\\SQLEXPRESS;database=Discos_DB;integrated security=true;");
            command = new SqlCommand();
        }
        public void setConsultation(string consulta)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = consulta;
        }

        public void ExecuteAction()
        {
            command.Connection = Connection;
            try
            {
                Connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void executeReading()
        {
            command.Connection = Connection;
            try
            {
                Connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex) 
            {

                throw ex;
            }
        }

        public void setParameters(string name,object value)
        {
            command.Parameters.AddWithValue(name, value);
        }

        public void closeConecction()
        {
            if (reader != null)
                reader.Close();
            Connection.Close();
        }
    }
}
