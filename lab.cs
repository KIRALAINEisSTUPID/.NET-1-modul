
//namespace lab
//{
//    internal class homework
//    {

//        public void PrintMessage()
//        {
//            Console.WriteLine("Hello,World");
//        }

//        public int vazifa2(int a)
//        {
//            return a * 2;
//        }

//        public void vazifa3(int a)
//        {
//            if (a > 0)
//            {
//                Console.WriteLine("Bu musbat son!");   
//            }
//            if (a < 0)
//            {
//                Console.WriteLine("Bu manfiy son!");
//            }


//        }

//        public void vazifa4(double a)
//        {
//            Console.WriteLine(Math.Round(a));
//        }

//        public void vazifa5(int a)
//        {
//            Console.WriteLine($"Sonning kvadrati:{a *a}");
//        }

//        public void vazifa6(double gradus)
//        {
//            Console.WriteLine($"Javob:{gradus * (3.14/180)} radian");
//        }

//        public void vazifa7(double a , double b) {

//            Console.WriteLine($"Javob:{a+b}");


//        }

//        public void vazifa8(double a, double b)
//        {
//            if (a > b)
//            {
//                Console.WriteLine($"{a} soni kataroq");
//            }
//            else
//            {
//                Console.WriteLine($"{a} soni kataroq");
//            }
//        }


//        public void vazifa9()
//        {
//            double a, b, c;
//            Console.Write("Boshlanish nuqtani kirting: ");
//            a = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Tugash nuqtani kirting: ");
//            b = Convert.ToDouble(Console.ReadLine());

//            while (true)  
//            {
//                Console.Write("Son kirting: ");
//                c = Convert.ToDouble(Console.ReadLine());

//                if (c >= a && c <= b)
//                {
//                    Console.WriteLine("Barakallo dostim, bu togri son!");
//                    break; 
//                }
//                else
//                {
//                    Console.WriteLine("Xato! Qaytadan kiriting.");
//                }
//            }
//        }

//        public void vazifa10() {
//            string matn;
//            Console.Write("Matn kiring:");
//            matn = Console.ReadLine();
//            Console.WriteLine($"Uzunligi:{matn.Length}");
//        }

//        public void vazifa12()
//        {
//            int son;
//            Console.Write("Son kiring:");
//            son = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine(son);
//        }

//        public void vazifa15()
//        {
//            string text;
//            Console.Write("Text kiriting");
//            text = Convert.ToString(Console.ReadLine());
//            string reversed = string.Concat(text.ToCharArray().Reverse());
//            Console.WriteLine(reversed);  
//        }

//        public void vazifa16()
//        {
//            double kelvin;
//            Console.WriteLine("Kelvin kriting:");
//            kelvin = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Javob:{kelvin - 273.15}");
//        }
//    }
//    //11 vazifa
//    internal class Person
//    {
//        public string name { get; set; }
//        public int age { get; set; } = 0;

//        public void SayHello()
//        {
//            Console.WriteLine($"Salom {name},yoshingiz:{age}");
//        }
//    }
//    // 14 mashq
//    internal class Car
//    {

//        public  void StartEngine()
//        {
//            Console.WriteLine("everything works i guess");
//        }
//    }
//}
