public struct ConnStr
{
    public string Server;
    public string Port;
    public string DB;
    public string User;
    public string Password;

    public override string ToString()
    {
        if (string.IsNullOrEmpty(Server))
            return "";
        return $"Server={Server},{Port};DataBase={DB};User Id={User};Password={Password}";
    }
}


