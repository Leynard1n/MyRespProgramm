using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

class CommandManager
{
    Dictionary<string, (string descr, CommandUser command)> Command = new();
    Dictionary<string, (string descr ,CommandGroup command)> commandsGroup = new();
    public void Start()
    {
        string command;
        do
        {
            Console.WriteLine();
            Console.WriteLine("Help - справка");
            Console.WriteLine("Введите команду");
            
                


            ;
            
            command  = Console.ReadLine();
            
            TestCommand(command);
        }
        while (command != "exit");

    }

    void TestCommand(string? command)
    {
        Console.WriteLine("Что хотите сделать(выберите цифру): 1. Описание 2. Выполнить");
        string d = Console.ReadLine();
        if (Command.ContainsKey(command))
        {
            if (d == "1")
                Console.WriteLine(Command[command].descr);
            else
                Command[command].command.Execute();
        }
        if (commandsGroup.ContainsKey(command))
        {
            if (d == "1")
                Console.WriteLine(commandsGroup[command].descr);
            else
                commandsGroup[command].command.Execute();
        }
    }
    

    public void RegisterCommand(string command, string descr, CommandUser commandUser)
    {
        Command.Add(command, (descr, commandUser));
    }
    public void RegisterCommandG(string command, string descr, CommandGroup commandGroup)
    {
        commandsGroup.Add(command, (descr, commandGroup));
    }


}
    
