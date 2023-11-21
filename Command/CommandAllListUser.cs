class CommandAllListUser : CommandUser
{
    private UserBD userBD;

    public CommandAllListUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.WriteLine("Нажмите Enter для продолжения");
        List<User> users = userBD.AllList(Console.ReadLine());
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].FirstName} {users[i].LastName}" +
                $" ,{users[i].NumberPhone}, {users[i].Addres} UID: {users[i].UID}" /*+
                $"{users[i].FullName}"*/);
                Console.WriteLine();
            }
    
    }
}