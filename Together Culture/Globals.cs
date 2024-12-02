using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Together_Culture
{
    public class Globals
    {
        public String current_dir;
        public String db_source;
        public String Conn_string;
        public void global_var()
        {
            
            current_dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            current_dir.Replace("\\", "/");
            
            db_source = current_dir + "\\Databases\\logindb.mdf";
            Conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + db_source + ";Integrated Security=True;Connect Timeout=30";
        }
        
    }
}
