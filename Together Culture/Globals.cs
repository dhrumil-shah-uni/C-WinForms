namespace Together_Culture
{
    public class Globals
    {
        //variables to handle it acroos all the classes and methods
        public String current_dir;
        public String db_source;
        public String Conn_string;

        //This is a class to handle Connection String according to the path of the Visual studio project
        //To solve the problem of database errors when trying to run in multiple workspaces

        public void global_var()
        {
            //Returns the current path of the project by finding it relative to the application debug folder
            current_dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            current_dir.Replace("\\", "/"); //replace the slashes to handle it better in a string

            //finds the database relative to the project folder
            //here, we have it inside Databases folder
            db_source = current_dir + "\\Databases\\together_culture.mdf";

            //Concatenate all the parts of the connection string
            Conn_string = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + db_source + ";Integrated Security=True;Connect Timeout=30";
        }
    }
}