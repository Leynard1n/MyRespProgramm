
class CommandCreateGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandCreateGroup(GroupBD groupBD)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.WriteLine("Выбор подарка...");
        Group newGroup = groupBD.CreateGroup();
        Console.WriteLine("Укажите Название...");
        newGroup.Operator = Console.ReadLine();
        if (groupBD.UpdateGroup(newGroup))
            Console.WriteLine("Подарок создан!");
        else
            Console.WriteLine("Возникли невозможные ошибки! Информация полностью уничтожена.");
    }
}
