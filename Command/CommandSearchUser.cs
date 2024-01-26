class CommandSearchUser : CommandUser
{
    private UserBD userBD;

    public CommandSearchUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.Write("Введите Имя или Фамилию : ");
        List<User> users = userBD.Search(Console.ReadLine());
        if (users.Count == 0)
            Console.WriteLine("Получатель не найден ");
        else
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {users[i].FirstName} {users[i].LastName}" +
                $" ,{users[i].NumberPhone} ,{users[i].Addres} UID: {users[i].UID}");
                Console.WriteLine();
            }
        
    }
}