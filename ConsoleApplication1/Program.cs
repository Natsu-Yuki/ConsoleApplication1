using System;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {
            
            MySql mySql = new MySql();
            //mySql.ExeMySql("insert into student value ('s003','司马懿');");
            var dataReader =  mySql.GetSqlDataReader("select * from student;");
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetString(0)+dataReader.GetString(1));
            }
        }
    }
}