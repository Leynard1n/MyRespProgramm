class CommandRemG : CommandGroup
{
    private GroupBD groupBD;

    public CommandRemG(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.Write("Введите подарок для удаления получателя: ");
        List<Group> groups = groupBD.SearchGroup(Console.ReadLine());

        for (int i = 0; i < groups.Count; i++)
        {
            Group remGroup = groups[i];
            
            if (!groupBD.RemGroup(remGroup))
                Console.WriteLine(" Удалён!");
            else
                Console.WriteLine("Возникли невозможные ошибки! Информация потеряна.");
        }
    }
}