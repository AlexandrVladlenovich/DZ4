//1 Вариант
Console.Clear();
var number = new int[8];
for (var n = 0; n < 8; n++)
{
   Console.Write("В новой строке введите одно из 8 чисел массива = ");
   number[n] = int.Parse(Console.ReadLine());
}
foreach (int i in number)
  Console.Write($"{i}, ","");
  
//2 Вариант
Console.Clear();
  int[] array = { 1, 2, 5, 7, 19 };
for (int i = 0; i < array.Length; i++)
{
    Console.Write((array[i]) + ", ");
}