Console.WriteLine("Привет");


        string fullName = "Артур";
        string group = "КАО исп-233";
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"Дата и время: {currentDate}");
        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату и время");
            Console.WriteLine("4 — Выход");
            Console.Write("Выбери пункт: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"ФИО: {fullName}");
                    break;
                case "2":
                    Console.WriteLine($"Группа: {group}");
                    break;
                case "3":
                    Console.WriteLine($"Дата и время: {DateTime.Now}");
                    break;
                case "4":
                    Console.WriteLine("Выход из программы");
                    return;
                default:
                    Console.WriteLine("Неверный пункт меню. Попробуйте снова.");
                    break;
            }
        }