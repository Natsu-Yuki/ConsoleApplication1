using System.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    public static class MySql
    {
        public  static MySqlConnection GetMySqlConnection()
        {
            string mysql = "server=localhost;user id=root;password=123456;database=natsusql";
            MySqlConnection mySqlConnection = new MySqlConnection(mysql);
            return mySqlConnection;
        }

        public static void ExeMySql(string mysql)
        {
            MySqlConnection mySqlConnection = GetMySqlConnection();
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(mysql,mySqlConnection);

            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.Dispose();
            mySqlConnection.Close();
            mySqlConnection.Dispose();

        }

        public static MySqlDataReader GetSqlDataReader(string mysql)
        {
            MySqlConnection mySqlConnection = GetMySqlConnection();
            MySqlCommand mySqlCommand = new MySqlCommand(mysql,mySqlConnection);
            mySqlConnection.Open();
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
            return mySqlDataReader;
        }
    }
    
    
    
    /*
     *
     *
     *
     *
     *
     *
     *
     *
     *
     *
     *
        MySql mySql = new MySql();
            mySql.ExeMySql("insert into student value ('s003','司马懿');");
            var dataReader =  mySql.GetSqlDataReader("select * from student;");
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetString(0)+dataReader.GetString(1));
            }
     *
     *
     *
     * 
     */
}