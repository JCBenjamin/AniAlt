using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

public sealed class MessageBox
{ }

public partial class _Default : Page
{
    MySql.Data.MySqlClient.MySqlConnection conn;
    string myConnectionString = "server=127.0.0.1; uid=root;" + "pwd=Animegirl;database=anialt;";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex);
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string search = txtProduct.Text;
    }
}