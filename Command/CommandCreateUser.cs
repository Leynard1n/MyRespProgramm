class CommandCreateUser : CommandUser
{
    private UserBD userBD;

    public CommandCreateUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.WriteLine("Добавление Получателя...");
        User newUser = userBD.Create();
        Console.WriteLine("Укажите имя..."); 
            string? v= Console.ReadLine();
        newUser.FirstName = v;
        Console.WriteLine("Укажите фамилию...");
        string? c = Console.ReadLine();
        newUser.LastName = c;
        Console.WriteLine("Укажите кто он вам");
        newUser.NumberPhone = Console.ReadLine();
        Console.WriteLine("Возвраст");
        newUser.Addres = Console.ReadLine();
        newUser.FullName = v + " " + c;
        if (userBD.Update(newUser))
            Console.WriteLine("Добавлен новый получатель!");
        else
            Console.WriteLine("Возникли невозможные ошибки! Информация полностью уничтожена.");
    }
}