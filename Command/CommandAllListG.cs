class CommandAllListG : CommandGroup
{
    private GroupBD groupBD;

    public CommandAllListG(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.WriteLine("Нажмите Enter для продолжения");
        List<Group> groups = groupBD.AllListG(Console.ReadLine());
        for (int i = 0; i < groups.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {groups[i].Operator} " +
                $"Пользователи: {groups[i].User}," +
            $"  UID: {groups[i].UID}" );
            Console.WriteLine();
        }

    }
}