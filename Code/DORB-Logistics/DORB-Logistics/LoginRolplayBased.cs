using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORB_Logistics
{
    class LoginRolplayBased
    {
        private static List<LoginDB> DB_Info = new List<LoginDB>();
        internal static string loggedinName = string.Empty;
        internal static int loggedinID;

        internal static void Login(string Username, string Password)
        {
            //Loading tables
            LoadTables();
            bool match = false;
            int MatchID = 0;

            for (int i = 0; i < DB_Info.Count; i++)
            {
                if (!match)
                {
                    //Build relations
                    List<DBrelation> Relations = new List<DBrelation>
                    {
                        new DBrelation(Username, DB_Info[i].UsernameField),
                        new DBrelation(Password, DB_Info[i].PasswordField)
                    };

                    //create connection and open it
                    MySqlConnection connection = new MySqlConnection(Db.ConString);
                    connection.Open();

                    //try to connect to database
                    try
                    {
                        //Build Mysql command
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + (DB_Info[i].TableName) + " WHERE " + (WHERE_builder(Relations)), connection);

                        //Get ID 
                        MySqlCommand id_cmd = connection.CreateCommand();
                        id_cmd.CommandText =
                            "SELECT `" + DB_Info[i].IDfieldname +
                            "` FROM `" + DB_Info[i].TableName +
                            "` WHERE `" + DB_Info[i].UsernameField + "` = '" + Username +
                            "' AND `" + DB_Info[i].PasswordField + "` = '" + Password + "'";

                        MySqlDataReader reader = id_cmd.ExecuteReader();


                        //if match is found
                        if (reader.Read())
                        {
                            //Set match info
                            match = true;
                            MatchID = int.Parse(reader[DB_Info[i].IDfieldname].ToString());
                           
                            //MessageBox.Show("Table: " + DB_Info[i].TableName + "\n Id: " + MatchID);

                            loggedinName = GetUsername(int.Parse(reader[DB_Info[i].IDfieldname].ToString()),DB_Info[i].TableName);

                            DB_Info[i].MatchID = MatchID;

                            loggedinID = MatchID;

                            OpenForm(DB_Info[i]);
                            break;
                        }
                    }
                    //finally
                    finally
                    {
                        //check state and clone
                        if (connection.State == ConnectionState.Open)
                            connection.Clone();
                    }
                }
                else
                    MessageBox.Show("Table: " + DB_Info[i].TableName + "\n Id: " + MatchID);
            }
            //If there is no match found in any of the loaded tables
            if (!match)
                MessageBox.Show("There was no match found in the following tables: \n" + LoadedTables_ToString());
        }
        private static void LoadTables()
        {
            //clear list first
            DB_Info.Clear();

            //new table
            Klant_main klant_frm = new Klant_main();
            DB_Info.Add(new LoginDB("klanten", klant_frm, "klant_id", "email", "wachtwoord"));

            Chauffeurs chauffeur_frm = new Chauffeurs();
            DB_Info.Add(new LoginDB("chauffeurs", chauffeur_frm, "chauffeur_ID", "inlognaam", "wachtwoord"));

            Planners Planners_frm = new Planners();
            DB_Info.Add(new LoginDB("planners", Planners_frm, "planner_ID", "inlognaam", "wachtwoord"));

            Managers Mannagers_frm = new Managers();
            DB_Info.Add(new LoginDB("managers", Mannagers_frm, "manager_ID", "inlognaam", "wachtwoord"));
        }
        private static void OpenForm(LoginDB Info)
        {

            switch (Info.FormToOpen)
            {
                case Klant_main klant:
                    Klant_main k = new Klant_main();
                    k.Show();
                    break;
                case Chauffeurs chaufeur:
                    Chauffeurs c = new Chauffeurs();
                    c.Show();
                    break;
                case Planners planner:
                    Planners p = new Planners();
                    p.Show();
                    break;
                case Managers manager:
                    Managers m = new Managers();
                    m.Show();
                    break;
            }
        }
        private static string GetUsername(int id, string table)
        {
            for (int i = 0; i < DB_Info.Count; i++)
            {
                if(DB_Info[i].TableName == table)
                {
                    //Build relations
                    List<DBrelation> Relations = new List<DBrelation>
                    {
                        new DBrelation(id.ToString(), DB_Info[i].IDfieldname)
                    };

                    //create connection and open it
                    MySqlConnection connection = new MySqlConnection(Db.ConString);
                    connection.Open();

                    //try to connect to database
                    try
                    {
                        //Build Mysql command
                        MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + (DB_Info[i].TableName) + " WHERE " + (WHERE_builder(Relations)), connection);

                        //Get Username 
                        MySqlCommand id_cmd = connection.CreateCommand();
                        id_cmd.CommandText =
                            "SELECT `" + DB_Info[i].UsernameField +
                            "` FROM `" + DB_Info[i].TableName +
                            "` WHERE `" + DB_Info[i].IDfieldname + "` = '" + id + "'";

                        MySqlDataReader reader = id_cmd.ExecuteReader();


                        //if match is found
                        if (reader.Read())
                            return reader[DB_Info[i].UsernameField].ToString();
                    }
                    //finally
                    finally
                    {
                        //check state and clone
                        if (connection.State == ConnectionState.Open)
                            connection.Clone();
                    }
                }
            }
                return "error";
        }

        private static string WHERE_builder(List<DBrelation> list)
        {
            string sentence = "";

            for (int i = 0; i < list.Count; i++)
            {
                //Add fieldname
                sentence += "`" + list[i].fieldname + "` = ";
                sentence += "`" + list[i].variable + "`";

                //AND if not final item of the list
                if(i < list.Count)
                    sentence += " AND ";
            }
            return sentence;
        }
        private static string LoadedTables_ToString()
        {
            string sentence = string.Empty;
            for (int i = 0; i < DB_Info.Count; i++)
            {
                //Add Table names
                sentence += "- " + DB_Info[i].TableName;

                //Next Line
                if (i < DB_Info.Count)
                    sentence += "\n";
            }
            return sentence;
        }
    }
}
class LoginDB
{
    //Db Info
    internal string TableName;

    internal string IDfieldname;
    internal string UsernameField;
    internal string PasswordField;
    internal int MatchID;

    //Final Info
    internal Form FormToOpen;
    
    public LoginDB (string _TableName, Form _FormToOpen, string _IDfieldname, string _UsernameField, string _PasswordField)
    {
        TableName = _TableName;
        FormToOpen = _FormToOpen;

        IDfieldname = _IDfieldname;
        UsernameField = _UsernameField;
        PasswordField = _PasswordField;
    }
}
class DBrelation
{
    internal string variable;
    internal string fieldname;

    public DBrelation(string _variable, string _fieldname)
    {
        this.variable = _variable;
        this.fieldname = _fieldname;
    }
}

//try amount
//Local or extern Database?
//Security methdoe [Hashed. dm5] for checking in database
