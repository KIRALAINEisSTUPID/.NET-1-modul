///*1.Jagged array yaratish va ekranga chiqarish
//2 Jagged array elementlari yig‘indisini hisoblash
//3 Jagged array ichidan eng katta elementni topish
//4 Jagged array ichidan eng kichik elementni topish 
//5 Har bir ichki massivning elementlar yig‘indisini hisoblash 
//6  Jagged arraydagi juft elementlarni chiqarish
//7  Jagged arraydagi toq elementlarni chiqarish
//8 Jagged arrayning har bir ichki qator uzunligini chiqarish 
//9  Berilgan son jagged array ichida bor yoki yo‘qligini tekshirish  
//10 Har bir ichki massiv elementlarini teskari tartibda chiqarish*/

//class Homework
//{


//    public static void Task(string[][] array)
//    {
//        foreach (string[] subArray in array)
//        {
//            foreach (string element in subArray)
//            {
//                Console.Write(element + " ");
//            }
//            Console.WriteLine();
//        }
//    }
//    public static void Task2(int[][] array)
//    {
//        int sum = 0;
//        foreach (int[] subArray in array)
//        {
//            foreach (int element in subArray)
//            {
//                sum += element;
//            }
//        }
//        Console.WriteLine(sum);
//    }

//    public static void Task3(int[][] array)
//    {
//        int a = int.MinValue;
//        foreach (int[] subArray in array)
//        {
//            foreach (int element in subArray)
//            {
//                if (element > a)
//                {
//                    a = element;

//                }
//            }
//        }

//        Console.Write(a);
//    }
//    public static void Task4(int[][] array)
//    {
//        int a = int.MaxValue
//            ;
//        foreach (int[] subArray in array)
//        {
//            foreach (int element in subArray)
//            {
//                if (element < a)
//                {
//                    a = element;

//                }
//            }
//        }

//        Console.Write(a);
//    }
//    public static int[] Task5(int[][] array)
//    {
//        int[] sums = new int[array.Length];

//        for (int i = 0; i < array.Length; i++)
//        {
//            sums[i] = array[i].Sum();
//        }

//        return sums;
//    }

//    public static void Task6(int[][] array)
//    {
//        Console.WriteLine("Juft elementlar:");
//        foreach (var subArray in array)
//        {
//            foreach (var num in subArray)
//            {
//                if (num % 2 == 0)
//                {
//                    Console.Write(num + " ");
//                }
//            }
//        }
//        Console.WriteLine();
//    }
//    public static void Task7(int[][] array)
//    {
//        Console.WriteLine("Toq elementlar:");
//        foreach (var subArray in array)
//        {
//            foreach (var num in subArray)
//            {
//                if (num % 2 != 0)
//                {
//                    Console.Write(num + " ");
//                }
//            }
//        }
//        Console.WriteLine();
//    }
//    public static void Task8(int[][] array)
//    {
//        Console.WriteLine("Har bir ichki qator uzunligi:");
//        for (int i = 0; i < array.Length; i++)
//        {
//            Console.WriteLine($"Qator {i + 1}: {array[i].Length} ta element");
//        }
//    }
//    public static void Task9(int[][] array, int target)
//    {
//        bool found = false;

//        foreach (var subArray in array)
//        {
//            foreach (var num in subArray)
//            {
//                if (num == target)
//                {
//                    found = true;
//                    break;
//                }
//            }
//            if (found) break;
//        }

//        if (found)
//            Console.WriteLine($"{target} soni jagged array ichida bor.");
//        else
//            Console.WriteLine($"{target} soni jagged array ichida yo‘q.");
//    }


//    public static void Main(string[] args)
//    {
//        {
//            string[][] names = new string[3][];
//            names[0] = new string[] { "Kama", "Elizabath", "Jaska" };
//            names[1] = new string[] { "Alice", "Bob" };
//            names[2] = new string[] { "Charlie", "Dave", "Eve", "Frank" };
//            int[][] ages = new int[3][];
//            ages[0] = new int[] { 3, 4, 4, 5, 6, 7, 8, 9 };
//            ages[1] = new int[] { 23, 43, 84, 65, 46, 37, 28, 19 };
//            ages[2] = new int[] { 234, 433, 844, 650, 468, 372, 282, 119 };


//            Task4(ages);
//        }
//    }
//}
