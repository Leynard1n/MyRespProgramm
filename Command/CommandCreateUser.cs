class CommandCreateUser : CommandUser
{
    private UserBD userBD;

    public CommandCreateUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.WriteLine("Создание Пользоватля...");
        User newUser = userBD.Create();
        Console.WriteLine("Укажите имя...");
        newUser.FirstName = Console.ReadLine();
        Console.WriteLine("Укажите фамилию...");
        newUser.LastName = Console.ReadLine();
        Console.WriteLine("Укажите Номер Телефона");
        newUser.NumberPhone = Console.ReadLine();
        Console.WriteLine("Укажите Адресс - (Город,Улица,дом,этаж,квартира)");
        newUser.Addres = Console.ReadLine();
        if (userBD.Update(newUser))
            Console.WriteLine("Пользотель создан!");
        else
            Console.WriteLine("Возникли невозможные ошибки! Информация полностью уничтожена.");
    }
}