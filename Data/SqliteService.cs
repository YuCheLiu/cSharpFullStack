using Newtonsoft.Json;
using System.Data.SQLite;
using System.Threading.Tasks;


namespace BlazorApp.Data
{
    public class SqliteService
    {
        string cs = "Data Source=:memory:";
        string stm = "SELECT SQLITE_VERSION()";

        static string dbFile =@"URI=file:.\test.db";
        static SQLiteConnection con;

        public SqliteService(){
            con = new SQLiteConnection(dbFile);
            con.Open();
        }
        public string connectDB(){
            using var cmd = new SQLiteCommand(stm, con);
            string version = cmd.ExecuteScalar().ToString();
            return version;   
        }
        public void createDB(){
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS member(id INTEGER PRIMARY KEY,
                    name TEXT, password TEXT) ";
            cmd.ExecuteNonQuery();
        }

        public void createNewMember(){
            using var cmd = new SQLiteCommand(con);
            cmd.CommandText = "INSERT INTO member(name, password) VALUES('Kim','cityu')";
            cmd.ExecuteNonQuery();          
        }

        public Task<MemberData> querymember(){
            string stm = "SELECT * FROM member LIMIT 1";
            using var cmd = new SQLiteCommand(stm, con);
            using SQLiteDataReader rdr = cmd.ExecuteReader();
            string name= "";
            string password ="";
            while (rdr.Read())
            {
                name = rdr.GetString(1);
                password = rdr.GetString(2);
            }
            return Task.FromResult(new MemberData
            {
                Name = name,
                Order = password
            });
        }
    }
}