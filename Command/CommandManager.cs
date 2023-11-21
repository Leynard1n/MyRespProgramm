using System.Collections.Generic;

class CommandManager
{
    Dictionary<string, (string descr, CommandUser command)> Command = new();
    public void Start()
    {
        string command;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Введите Одну из команд");



            ;
            command = Console.ReadLine();
            TestCommand(command);
        }
        while (command != "exit");

    }

    void TestCommand(string? command)
    {
        if (Command.ContainsKey(command))
        {
            Console.WriteLine("Что хотите сделать(выберите цифру): 1. Описание 2. Выполнить");
            string d = Console.ReadLine();
            if (d == "1")
                Console.WriteLine(Command[command].descr);
            else
                Command[command].command.Execute();
        }
    }
    public void RegisterCommand(string command, string descr, CommandUser commandUser)
    {
        Command.Add(command, (descr, commandUser));
    }
}
    
