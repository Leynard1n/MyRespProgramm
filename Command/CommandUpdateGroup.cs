class CommandEditGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandEditGroup(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.Write("Введите Наименоание Оператора для Внесений изменений: ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());

        for (int i = 0; i < groups.Count; i++)
        {
            Group edGroup = groups[i];
            Console.WriteLine("Укажите Новое название Оператора ");
            edGroup.Operator = Console.ReadLine();
            if (!groupBD.UpdateGroup(edGroup))
                Console.WriteLine(" Оператор Переимменован!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация потеряна.");
        }
    }
}
