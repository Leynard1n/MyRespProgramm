class CommandDeleteGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandDeleteGroup(GroupBD groupDB)
    {
        this.groupBD = groupDB;
    }

    public override void Execute()
    {
        Console.Write("Введите Имя Оператора для Удаления: ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());
        for (int i = 0; i < groups.Count; i++)
            groupBD.DeleteGroup(groups[i]);
        Console.WriteLine("Группа Была Удалена!");
    }
}