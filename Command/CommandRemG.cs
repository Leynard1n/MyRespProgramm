class CommandRemG : CommandGroup
{
    private GroupBD groupBD;

    public CommandRemG(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.Write("Введите Наименоание Оператора для Удаления пользователей: ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());

        for (int i = 0; i < groups.Count; i++)
        {
            Group remGroup = groups[i];
            
            if (!groupBD.RemGroup(remGroup))
                Console.WriteLine(" Пользователи Удалёны!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация потеряна.");
        }
    }
}