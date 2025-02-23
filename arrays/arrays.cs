//using System;

//class Arrays
//{
//    static void MaxNumbers(int[] array)
//    {
//        int max = array[0]; 

//        for (int i = 1; i < array.Length; i++) 
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//            }
//        }

//        Console.WriteLine("maksimal  " + max);

//        static void MinNumbers(int[] array)
//    {
//            int min = array[0]; // Берём первый элемент за минимум

//            for (int i = 1; i < array.Length; i++) // Начинаем с 1, потому что 0 уже в min
//            {
//                if (array[i] < min) // Если нашли меньшее число, обновляем min
//                {
//                    min = array[i];
//                }
//            }

//            Console.WriteLine("Eng kichkina son: " + min);
//    }

//        static void Main(string[] args)
//    {
//        int[] nums = { 1, 2, 3, 4, 5, 64, 6, 7, 8, 9, 102 };

//        MaxNumbers(nums); 
//    }
//}
