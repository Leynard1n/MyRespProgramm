class CommandAddTOGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandAddTOGroup(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.Write("Введите Наименоание Оператора для добавления пользователя: ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());

        for (int i = 0; i < groups.Count; i++)
        {
            Group addGroup = groups[i];
            Console.WriteLine("Укажите пользователя ");
            addGroup.User = Console.ReadLine();
            if (!groupBD.AddGroup(addGroup))
                Console.WriteLine(" Пользователь добавлен!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация потеряна.");
        }
    }
}

