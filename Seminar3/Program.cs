// Одна из задач из ДЗ 9пересмотреть код)

// Sistem.Console.Writeline("ВВедите число:");
// string number = Console.Readline();
// if (number.Length <3){
// //     Sistem.Console.WriteLine("Ошибка! \nЧисло должно сождержать не менее трех знаков");

// // }
// // else {
// //     Sistem.Console.Writeline(number[2]);

// // }
// // Console.WriteLine(Convert.ToInt32(Convert.ToString(number[2]))+ 10);


// // Задача 1. 

// Console.WriteLine("Введите переменную y:");
// int x = Convert.ToInt32(Console.ReadLine()); // это можно использовать
// int y = int.Parse(Console.ReadLine()); // это тоже можно использовать
// if (x==0 || y==0){
// Console.WriteLine("Точка находится в первой части");
// }
// else if (x > 0 && y >0){
// Console.WriteLine("  Точка находится во второй четверти");
// }
// else if (x < 0 && y < 0){
// Console.WriteLine(" Точка находится в третьей четверти");
// }
// else if (x > 0 && y <0){
// Console.WriteLine(" Точка находится в четвертой четверти");
// }
// else{
// Console.WriteLine(" X и Y не должны равняться 0");
// }



// Задача2 Напишите программу, которая по заданному номеру четверти, показывает  
// диапазон возможных координат точек в этой четверти (x и y). 


// System.Console.WriteLine("Введи номер четверти:");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num==1){
//     System.Console.WriteLine("x>0 && y>0 Первая четверть");
// }

// else if (num==2){
//     System.Console.WriteLine("x<0 && y>0 Вторая четверть");
// }

// else if (num==3){
//     System.Console.WriteLine("x<0 && y<0 Третья четверть");
// }

// else if (num==4){
//     System.Console.WriteLine("x>0 && y<0 Четвертая четверть");
// }

// else {
//     System.Console.WriteLine("Такой четверти не сущкствует");
// }


//Задача3 Напишите программу, котораz принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве

// (x1-x2)^2 + (y1-y2)^2)^1/2)

// System.Console.WriteLine("Введите координату х точки А: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату у точки А: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите координату х точки Б: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату y точки Б: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double result = Math.Round(Math.Sqrt(Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)),1);  //((x1-x2)*(x1-x2)) + (y1-y2)*(y1-y2))) /1.5

// System.Console.WriteLine($"Расстояние между двумя точками {result}");




// Задача4 Напишите программу которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N

// Решение 1
System.Console.Write("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
for (int i =1; i <=x; i++){
    System.Console.WriteLine(Math.Pow(i, 2));
}

// Решение2
// System.Console.Write("Введите число:");
// int x = Convert.ToInt32(Console.ReadLine());
// int count = 1; // счетчик
// while (count<=x){
//     System.Console.WriteLine(Math.Pow(count, 2 + " ")); // задача с условием while, +" " прописывание в строку
//     count++;
//  }



// Выведите четные числа от 1 до 15 

// for(int i=1; i<=15; i++);
// if (i%2 ==0){
//     System.Console.Write(i+" ");
// }

// for (int i = 2; i<= 15; i = i+2);
// if (i % 2 ==0){
//     System.Console.Write(i+" ");
// }

// string text = Console

// if (text.Length == 5){} // ычисление кол-ва знаков в числе




