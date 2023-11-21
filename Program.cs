using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Xml.Linq;


// Поиск изменение и удаление данных про оператору связи ( номер телефона , Имя фамилия, Адресс прописки или факт и оператор связи)
class Program
{
    public static void Main()
    {
        UserBD userBD = new UserBD();
        CommandManager commandManager = new CommandManager();
        GroupBD groupBD = new GroupBD();

        //Команды для User

            commandManager.RegisterCommand("Create", "Создаёт пользователя", new CommandCreateUser(userBD));
            commandManager.RegisterCommand("Find", "Ищет Пользователя", new CommandSearchUser(userBD));
            commandManager.RegisterCommand("Del", "Удаляет Данные пользователя", new CommandDeleteUser(userBD));
            commandManager.RegisterCommand("Update", "Изменяет Данные пользователя", new CommandUpdateUser(userBD));
            commandManager.RegisterCommand("List", "Показывает Всех пользователей", new CommandAllListUser(userBD));

        //Команды для Group
        commandManager.RegisterCommandG("CreateG","Создаёт Оператора", new CommandCreateGroup(groupBD));
        commandManager.RegisterCommandG("FindG","Ищет Оператора", new CommandSearchGroup(groupBD));
        commandManager.RegisterCommandG("DelG", "Удаляет Оператора",new CommandDeleteGroup(groupBD));
        commandManager.RegisterCommandG("UpdateG","Обнавляет данные Операторов", new CommandEditGroup(groupBD));
        commandManager.RegisterCommandG("Add", "Добавляет В группу" +
            "", new CommandAddTOGroup(groupBD));


        commandManager.Start();
    }
}