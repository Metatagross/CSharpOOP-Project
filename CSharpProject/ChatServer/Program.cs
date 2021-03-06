using ChatServer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

static class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main ( )
    {
        string path = Path.Combine(Directory.GetCurrentDirectory() , "ArchiveUsers.xml");
        UserCollection listOfUsers = new UserCollection()
        {
            Users = new List<User>() {new User("maria_9578", "mariaPos"),
        new User("kaloyan.dimitrov", "koko8754"),
        new User("metodi_48", "metodiA"),
        new User("porimia.banana", "bananaM8"),
        new User("kompana_bora", "boraBora"),
        new User("ivan_ivanov", "van4o4o4o")}
        };
        XmlSerializer xmlSer = new XmlSerializer(typeof(UserCollection));
        TextWriter txtW = new StreamWriter(path);

        xmlSer.Serialize(txtW , listOfUsers);

        txtW.Close();
        Application.EnableVisualStyles();
        Application.Run(new ChatServerForm());
    }
}
