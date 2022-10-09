// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    
int [] NumM = new int[20];
int count = 0;
Console.Write("[");
for (int i = 0; i < NumM.Length; i++)
 {
    NumM [i] = new Random().Next(-100, 100);
    Console.Write(" " + Array (i) + " ");
    if(NumM[i] > 0)
      {
       count++;
       i++;
      }
 }
Console.Write($"]-> {count}");

int Array (int a)
{
    return NumM[a];
}


