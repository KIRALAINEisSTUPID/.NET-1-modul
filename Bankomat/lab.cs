using System;
using System.Net.Mail;

namespace lab
{
    class Bank
    {



        public static void StartMenu(string[] usersname, string[] password)
        {
            Console.WriteLine("PDP Bankiga hush kelibsiz");
            Thread.Sleep(2000);
            Console.Clear();
            Login(usersname, password);


        }
        public static void Login(string[] usersname, string[] password)
        {
            string login;
            string parol;
            bool loginTrue = false;
            bool passTrue = false;
            Console.WriteLine("PDP Bankiga hush kelibsiz");
            Console.Write("Login kiriting:"); login = Convert.ToString(Console.ReadLine());
            Console.Write("Parol kiriting kiriting:"); parol = Convert.ToString(Console.ReadLine());
            foreach (string element in usersname)
            {
                if (element == login)
                {
                    loginTrue = true;
                    foreach (string savedpassword in password)
                    {
                        if (savedpassword == parol)
                        {
                            passTrue = true;
                        }
                    }
                }
            }
            if (loginTrue == true && passTrue == true)
            {
                Console.WriteLine($"Salom {login}");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu();



            }
            else
            {
                Console.WriteLine("Parol yoki LOGIN xato programmani qaytadan boshlaymiz");
                Thread.Sleep(3000);
                Console.Clear();
                StartMenu(usersname, password);

            }



        }
        public static void MainMenu()
        {
            char choice;
            Console.WriteLine("1.Balansni ko'rish");
            Console.WriteLine("2.Tranzaksiyalar");
            Console.WriteLine("3.SMS kartani ulash!");
            Console.WriteLine("4.Kazino");
            choice = Console.ReadKey().KeyChar;
            if (choice == '1')
            {
                Console.Clear();
                Thread.Sleep(2000);
                Balance("100$");


            }
            else if (choice == '2')
            {
                Console.Clear();
                Thread.Sleep(2000);
                History(new string[] { });
            }
            else if (choice == '3')
            {
                Console.Clear();
                Thread.Sleep(2000);
                SMS();
            }
            else if (choice == '4')
            {
                Console.Clear();
                Thread.Sleep(2000);
                Kazino();
            }

        }

        public static void Balance(string money)
        {
            char choice;
            Console.WriteLine($"Sizning pulingiz:{money}");
            Console.WriteLine("1.Orqaga qaytasizmi?"); choice = Console.ReadKey().KeyChar;
            if (choice == '1')
            {
                MainMenu();
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu();

            }
            else
            {
                Console.WriteLine("orqaga qaytishga majbursiz!!!");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu();
            }
        }
        public static void History(string[] bought)
        {
            Console.WriteLine("Sizning tarixingiz:");
            foreach (string transaction in bought)
            {
                Console.Write(transaction);
                Console.WriteLine();

            }
            Console.ReadKey();
            Thread.Sleep(2999);
            Console.Clear();
            MainMenu();
        }
        public static void SMS()
        {
            string number;
            Console.WriteLine("Telefon raqamingizni ulaysizmi"); number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Telefon raqamingz saqland(yolgon)");


        }



        public static void Kazino()
            {
                int choice;
                Random rnd = new Random();
                Console.Write("Son tanlang (1-10), agar tasodifiy son bilan teng bo‘lsa, 10000$ yutib olasiz: ");

                choice = Convert.ToInt32(Console.ReadLine());

                int randomNumber = rnd.Next(1, 11);
                
                    Console.WriteLine(randomNumber + "...");

                if (randomNumber == choice)
                {
                    Console.Clear();
                    Console.WriteLine("Siz 10000$ yutib oldingiz!");
                    Console.ReadKey();
                    Thread.Sleep(2000);
                    Console.Clear();
                    MainMenu();
                }

                else
                {
                    Console.WriteLine("Yutqazdingiz! Qayta urinib ko'ring.");

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = "microsoft-edge:https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                        UseShellExecute = true
                    });
                }
        }


    }

    class Shop
    {

        public static void StartMenu(string[] usersname, string[] password)
        {
            Console.WriteLine("PDP Shopiga  hush kelibsiz");
            Thread.Sleep(2000);
            Console.Clear();
            Login(usersname, password);


        }
        public static void Login(string[] usersname, string[] password)
        {
            string login;
            string parol;
            bool loginTrue = false;
            bool passTrue = false;
            Console.WriteLine("PDP Bankiga hush kelibsiz");
            Console.Write("Login kiriting:"); login = Convert.ToString(Console.ReadLine());
            Console.Write("Parol kiriting kiriting:"); parol = Convert.ToString(Console.ReadLine());
            foreach (string element in usersname)
            {
                if (element == login)
                {
                    loginTrue = true;
                    foreach (string savedpassword in password)
                    {
                        if (savedpassword == parol)
                        {
                            passTrue = true;
                        }
                    }
                }
            }
            if (loginTrue == true && passTrue == true)
            {
                Console.WriteLine($"Salom {login}");
                Thread.Sleep(2000);
                Console.Clear();
                MainMenu();



            }
            else
            {
                Console.WriteLine("Parol yoki LOGIN xato programmani qaytadan boshlaymiz");
                Thread.Sleep(3000);
                Console.Clear();
                StartMenu(usersname, password);

            }


        }
        public static void MainMenu()
        {
            char choice;
            Console.WriteLine("1.Kitobni qoshish");
            choice = Console.ReadKey().KeyChar;
            if (choice == '1')
            {

                AddBook();
            }
            else
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "microsoft-edge:https://www.youtube.com/watch?v=dQw4w9WgXcQ",
                    UseShellExecute = true
                });
            }
        }

        public static void AddBook()
        {


            char choice;

            Console.Write("1. sotib olish qoshish");
            choice = Console.ReadKey().KeyChar;
            if (choice == '1')
            {
                Console.Write("Qaysi kitobni sotib olasiz:"); choice = Console.ReadKey().KeyChar;
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "microsoft-edge:/{}",
                    UseShellExecute = true
                });

            }

        }


        }


    }

