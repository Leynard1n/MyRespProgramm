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
            Console.WriteLine("Help - ответ");
            Console.WriteLine("Введите номер программы");
            
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
            if (d == "Help")
                Console.WriteLine(Command[command].descr);
            else
                Command[command].command.Execute();
        }
        if (commandsGroup.ContainsKey(command))
        {
            if (d == "Help")
                Console.WriteLine(commandsGroup[command].descr);
            else
                commandsGroup[command].command.Execute();
        }
    }
    
    /*public void Help()
    {
        string c, v;
        
        Console.WriteLine("Введите команду...");
        List<string> list1 = new List<string>() { "Create", "Del", "Update", "List", "Find", "CreateG", "FindG", "DelG", "UpdateG", "ListG", "Rem", "Add" };
        v =c=Console.ReadLine();
        if (Command.ContainsKey(c)) 
        {
                if (c == "Help")
            {
                foreach (string s in list1) Console.WriteLine(Command[s].descr);
            }
            else
                Command[c].command.Execute();
        }
        if (commandsGroup.ContainsKey(c))
        {
            if (c == "Help")
                Console.WriteLine(commandsGroup.ToList());
            else
                commandsGroup[c].command.Execute();
        }
    }*/
    public static void List()
    {
        List<string> list1 = new List<string>() { "Create", "Del", "Update", "List", "Find", "CreateG", "FindG", "DelG", "UpdateG", "ListG", "Rem", "Add"};
       

        
        {
            foreach (string s in list1) Console.WriteLine(s);
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
    
