class CommandUpdateUser : CommandUser
{
    private UserBD userBD;

    public CommandUpdateUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.Write("Введите имя или фамилию Пользователя, которого хотите исправить: ");
        List<User> users = userBD.Search(Console.ReadLine());

        for (int i = 0; i < users.Count; i++)
        {
            User upUser = users[i];
            Console.WriteLine("Укажите Изменение имени: ");
            string? v = Console.ReadLine();
            upUser.FirstName = v;
            Console.WriteLine("Укажите новую фамилию: ");
            string? c = Console.ReadLine();
            upUser.LastName = c;
            Console.WriteLine("Укажите Новый телефон: ");
            upUser.NumberPhone = Console.ReadLine();
            Console.WriteLine("Укажите новый адресс- (Город,Улица,дом,этаж,квартира): ");
            upUser.Addres = Console.ReadLine();
            upUser.FullName = v +" "+ c;
            if (userBD.Update(upUser))
                Console.WriteLine("Пользователь Изменён!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация не изменена.");
        }
    }
}


