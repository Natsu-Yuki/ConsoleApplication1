using System.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    public class MySql
    {
        public  MySqlConnection GetMySqlConnection()
        {
            string mysql = "server=localhost;user id=root;password=123456;database=natsusql";
            MySqlConnection mySqlConnection = new MySqlConnection(mysql);
            return mySqlConnection;
        }

        public void ExeMySql(string mysql)
        {
            MySqlConnection mySqlConnection = this.GetMySqlConnection();
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(mysql,mySqlConnection);

            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.Dispose();
            mySqlConnection.Close();
            mySqlConnection.Dispose();

        }

        public MySqlDataReader GetSqlDataReader(string mysql)
        {
            MySqlConnection mySqlConnection = this.GetMySqlConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(mysql,mySqlConnection);
            mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return mySqlDataReader;
        }
    }
}