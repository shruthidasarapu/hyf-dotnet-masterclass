public class Shared
{
    public static string ConnectionString = string.IsNullOrEmpty(Environment.GetEnvironmentVariable("MYSQLCONNSTR_mealSharingdb")) ?
   "Server=localhost;Database=mealapplication;Uid=root;Pwd=password;Convert Zero Datetime=True" :
   Environment.GetEnvironmentVariable("MYSQLCONNSTR_mealSharingdb");
}