using System.Data.SqlClient;

static class Global
{
    public static string userName = "tinh";
    public static string connectionString = @"Data Source=DESKTOP-9R6JGJB\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True";

    public static string curentPage = "Trang chủ";


    public static SqlConnection GetSqlConnection()
    {
        return new SqlConnection(connectionString);
    }
}

