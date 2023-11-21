class CommandDeleteUser : CommandUser
{
    private UserBD userBD;

    public CommandDeleteUser(UserBD userBD)
    {
        this.userBD = userBD;
    }

    public override void Execute()
    {
        Console.Write("Введите данные пользователя которого нужно удалить: ");
        List<User> users = userBD.Search(Console.ReadLine());
        for (int i = 0; i < users.Count; i++)
            userBD.Delete(users[i]);
        Console.WriteLine("Пользователь был удалён!");
    }
}