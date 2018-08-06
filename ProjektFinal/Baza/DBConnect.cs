using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
//MySQL biblioteka
using MySql.Data.MySqlClient;

namespace BazaDanychMySQL
{
    public class DBConnect
    {
        private string server;
        private string database;
        private string uid;
        private string password;

        //private MySqlConnection cn;
        private string connectionString;

        public string Database { get => database; set => database = value; }
        public string Server { get => server; set => server = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Password {  set => password = value; }

        NumberFormatInfo nfi = new NumberFormatInfo();

        public DBConnect(string server, string uid, string password, string database)
        {
            Initialize(server,uid,password,database);
            nfi.NumberDecimalSeparator = ".";
        }

        private void Initialize(string server, string uid, string password, string database)
        {
            this.Server = server;
            this.Uid = uid;
            this.Password = password;
            this.Database = database;
            refreshConnection();
           
        }

        public void refreshConnection()
        {
            try
            {
                connectionString = CreateConnectionString(Server, Database, Uid, password);
                //cn = new MySqlConnection(connection);
            }
            catch (ArgumentException ex)
            {
                //do implementacji
            }
        }
        private string CreateConnectionString(params string[] cnList) {
            string result="";

            if (cnList.Length != 4){
                throw new ArgumentException("Zła liczba parametrów przesłana do metody CreateConnectionString!");
            }

            string[] desc = { "SERVER=", "DATABASE=","UID=","PASSWORD=" };

            for (int i= 0; i < 4; i++)
            {
                result += desc[i] + cnList[i] + ";";
            }
            result += "Connection Timeout=1;";
            return result;
        }
        public bool ValidateDB()
        {
            refreshConnection();
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                if (this.OpenConnection(cn) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }         
        }

        //open connection to database
        private bool OpenConnection(MySqlConnection cn)
        {
            try
            {
                cn.Open();
                return true;
            }
            catch(MySqlException ex)
            {

                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:                        
                       //MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                       // MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection(MySqlConnection cn)
        {
            try
            {
                cn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }


        public string CreateInsertQuery(float temp, float pres, float hum)
        {
            return "INSERT INTO tblweathersample (Timestamp, Temperature, Pressure, Humidity) " +
                "VALUES ( NOW(), " + temp.ToString(nfi) + ", " + pres.ToString(nfi) + ", " + hum.ToString(nfi) + ");";
        }
        public string CreateInsertQuery(DateTime dateTime, float temp, float pres, float hum)
        {
            return "INSERT INTO tblweathersample (Timestamp, Temperature, Pressure, Humidity) " +
                "VALUES ('" + dateTime.ToString("yyyy-MM-dd HH:mm:ss") +"' , " + temp.ToString(nfi) + ", " + pres.ToString(nfi) + ", " + hum.ToString(nfi) + ");";
        }
        //Insert statement
        public bool Insert(string query)
        {
            using(MySqlConnection cn = new MySqlConnection(connectionString))
            {
                if (this.OpenConnection(cn) == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, cn);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception e)
                    {
                        throw e;
                        return false;
                    }
                    //Execute command


                    //close connection
                    this.CloseConnection(cn);
                }
                else
                {
                    return false;
                }
            
            }
        }

        //Update statement
        public void Update()
        {
        }

        //Delete ALL rows statement
        public void Delete()
        {
            string query = "DELETE FROM tblweathersample";

            ExecuteQuery(query);
        }


        private void ExecuteQuery(string query)
        {
            using(MySqlConnection cn = new MySqlConnection(connectionString))
            {
                if (this.OpenConnection(cn) == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection(cn);
                }
            }
        }
        public void Delete(int rows)
        {
            string query = "DELETE FROM `tblweathersample` WHERE id IS NOT NULL order by Timestamp asc LIMIT " + rows.ToString();

            ExecuteQuery(query);
        }

        //Select statement
        public string CreateSelectQuery(timespan timespan, int units, bool single)
        {
            string result;

            
            if(timespan == timespan.sample)
            {
                if (single)
                {
                    int pom = units - 1;
                    result = "Select Timestamp, Pressure,Temperature, Humidity FROM tblweathersample ORDER BY Timestamp DESC LIMIT " + pom.ToString() + "," +
                    units.ToString();
                }
                else
                {
                    result = "Select Timestamp, Pressure,Temperature, Humidity FROM tblweathersample ORDER BY Timestamp DESC LIMIT 0," + units.ToString() ;
                }
                
            }
            else
            {
                bool day = (timespan == timespan.day);
                bool hour = (timespan == timespan.hour);
                bool minute = (timespan == timespan.minute);
                if (single)
                {
                    result = MakeAggregation(day, hour, minute, units);
                }
                else
                {
                    result = MakeGroupAgg(day, hour, minute, units);
                }
               
            }

            return result;
        }

        private string MakeAggregation(bool day,bool hour,bool minute, int unit)
        {
            bool executionIsValid = day ^ hour ^ minute;
            if (unit < 1)
                executionIsValid = false;

            if (!executionIsValid)
            {
                ArgumentException e = new ArgumentException("Niepoprawne wywolanie metody");
                throw e;
            }


            int beginTime=(day ? 1: 0)*(24+24*unit-1)+(hour? 1:0)*(60 + 60 * unit - 1) + (minute? 1:0) * (60 +60*unit-1);
            int endTime = (day ? 1 : 0) * 24 + beginTime + (hour ? 1 : 0) * 60 + beginTime + (minute ? 1 : 0) * 60 + beginTime;

            string timeUnit= (day ? "DAY" : (hour ? "HOUR" : "MINUTE") );

            string query = "Select MIN(Timestamp) as Timestamp, AVG(Temperature) as Temperature, " 
                + "AVG(Pressure) as Pressure, AVG(Humidity) as Humidity"+
                " FROM tblweathersample"+
                " WHERE Timestamp BETWEEN DATE_SUB(NOW(), INTERVAL " + unit.ToString() + " " + timeUnit+")" +
                " AND DATE_SUB(NOW(), INTERVAL " + (unit-1).ToString() + " " + timeUnit + ")";

            return query;
        }
        public string MakeGroupAgg(bool day, bool hour, bool minute, int unit)
        {
            if (validateDB(day, hour, minute, unit) == false)
            {
                ArgumentException e = new ArgumentException("Niepoprawne wywolanie metody");
                throw e;
            }
            int beginTime = (day ? 1 : 0) * (24 + 24 * unit - 1) + (hour ? 1 : 0) * (60 + 60 * unit - 1) + (minute ? 1 : 0) * (60 + 60 * unit - 1);

            string timeUnit = (day ? "DAY" : (hour ? "HOUR" : "MINUTE"));
            string group = " GROUP BY YEAR(Timestamp), Day(Timestamp)" + (hour ? ", HOUR(Timestamp)":"") + (minute ? ", MINUTE(Timestamp)":"");

            string query = "SELECT FROM_UNIXTIME(AVG(UNIX_TIMESTAMP(Timestamp) )) AS TIMESTAMPs, AVG(Pressure) as Pressure, AVG(Temperature) as Temperature, AVG(Humidity) as Humidity" +
            " FROM tblWeatherSample WHERE Timestamp BETWEEN DATE_SUB(NOW(), INTERVAL " + unit.ToString() + " " + timeUnit + ")" +
               " AND NOW()" + group;

            return query;
        }

        private bool validateDB(bool day, bool hour, bool minute, int unit)
        {
            bool executionIsValid = day ^ hour ^ minute;
            if (unit < 1)
                executionIsValid = false;

            return executionIsValid;
        }
        public List<string>[] Select(string query)
        {
            //Create a list to store the result
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            //list[4] = new List<string>();

            using(MySqlConnection cn = new MySqlConnection(connectionString))
            {
                //Open connection
                if (this.OpenConnection(cn) == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {

                        //list[0].Add(dataReader["id"] + "");
                        list[0].Add(dataReader[0] + "");
                        list[1].Add(dataReader["Temperature"] + "");
                        list[2].Add(dataReader["Pressure"] + "");
                        list[3].Add(dataReader["Humidity"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection(cn);

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tblweathersample";
            int Count = -1;
            using(MySqlConnection cn = new MySqlConnection(connectionString))
            {
                //Open Connection
                if (this.OpenConnection(cn) == true)
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, cn);

                    //ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");

                    //close Connection
                    this.CloseConnection(cn);

                    return Count;
                }
                else
                {
                    return Count;
                }
            }
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
