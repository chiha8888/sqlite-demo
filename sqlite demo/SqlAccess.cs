using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace sqlite_demo
{
    class SqlAccess
    {
        public bool insert(string name)
        {
            
            if (!File.Exists(Application.StartupPath+@"\food.db"))
            {
                return false;
            }
            using (SQLiteConnection sqlite_connect=new SQLiteConnection("Data source=food.db"))
            {
                sqlite_connect.Open();
                string cmdString = "insert into food(name) values ('" + name + "')";
                SQLiteCommand cmd = new SQLiteCommand(cmdString, sqlite_connect);
                Convert.ToInt32(cmd.ExecuteNonQuery());
                sqlite_connect.Close();
            }
            return true;
        }
        public int count(string name)
        {
            int re;
            if (!File.Exists(Application.StartupPath + @"\food.db"))
            {
                return -1;
            }
            using (SQLiteConnection sqlite_connect = new SQLiteConnection("Data source=food.db"))
            {
                sqlite_connect.Open();
                string cmdString = "select count(*) from food where name='" + name + "'";
                SQLiteCommand cmd = new SQLiteCommand(cmdString, sqlite_connect);
                re = Convert.ToInt32(cmd.ExecuteScalar());
                sqlite_connect.Close();
            }
            return re;
        }

    }
}
