class CommandEditGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandEditGroup(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.Write("Введите Наименоание Подарка для Внесений изменений: ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());

        for (int i = 0; i < groups.Count; i++)
        {
            Group edGroup = groups[i];
            Console.WriteLine("Укажите Новый Подарок ");
            edGroup.Operator = Console.ReadLine();
            if (!groupBD.UpdateGroup(edGroup))
                Console.WriteLine(" Измененно!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация потеряна.");
        }
    }
}
