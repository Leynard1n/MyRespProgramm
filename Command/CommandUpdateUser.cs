class CommandUpdateUser : CommandUser
{
    private UserBD userBD;

    public CommandUpdateUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.Write("Введите имя или фамилию , для исправления Ошибки: ");
        List<User> users = userBD.Search(Console.ReadLine());

        for (int i = 0; i < users.Count; i++)
        {
            User upUser = users[i];
            Console.WriteLine("Укажите  именя: ");
            string? v = Console.ReadLine();
            upUser.FirstName = v;
            Console.WriteLine("Укажите новую фамилию: ");
            string? c = Console.ReadLine();
            upUser.LastName = c;
            Console.WriteLine("Укажите Новый статус: ");
            upUser.NumberPhone = Console.ReadLine();
            Console.WriteLine("Укажите новый Возвраст: ");
            upUser.Addres = Console.ReadLine();
            upUser.FullName = v +" "+ c;
            if (userBD.Update(upUser))
                Console.WriteLine("Получатель Изменён!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация не изменена.");
        }
    }
}


