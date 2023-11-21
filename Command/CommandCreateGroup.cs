using System.Text.RegularExpressions;

class CommandCreateGroup : CommandGroup
{
    private GroupBD groupBD;

    public CommandCreateGroup(GroupBD groupDB)
    {
        this.groupBD = groupBD;
    }

    public override void Execute()
    {
        Console.WriteLine("Создание оператора...");
        Group newGroup = groupBD.CreateGroup();
        Console.WriteLine("Укажите Оператора...");
        newGroup.Operator = Console.ReadLine();
        if (!groupBD.UpdateGroup(newGroup))
            Console.WriteLine("Оператор создан!");
        else
            Console.WriteLine("Возникли невозможные! Информация уничтожена.");
    }
}
