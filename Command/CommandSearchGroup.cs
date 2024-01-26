class CommandSearchGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandSearchGroup(GroupBD groupBD)
    {
        this.groupBD = groupBD; 
        
    }

    public override void Execute()
    {
        Console.Write("Введите Имя для поиска ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());
        if (groups.Count == 0)
            Console.WriteLine("Не найден, проверьте правильность введённых данных");
        else
            for (int i = 0; i < groups.Count; i++)
            { Console.WriteLine($"{i + 1}. {groups[i].User} {groups[i].Operator} UID: {groups[i].UID}"); }
    }
}