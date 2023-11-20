// Поиск изменение и удаление данных про оператору связи ( номер телефона , Имя фамилия, Адресс прописки или факт и оператор связи)
UserBD userBD = new UserBD();
CommandManager commandManager = new CommandManager();


commandManager.RegisterCommand("Create", new CommandCreateUser(userBD));