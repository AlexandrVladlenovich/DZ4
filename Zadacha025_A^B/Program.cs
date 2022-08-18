Console.Clear();
Console.WriteLine("Введите переменную A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную B");
int b = Convert.ToInt32(Console.ReadLine());
int b2 = b;
int a2 = a;
while (b > 1)
    {
      b = b - 1;
      a = a * a2;
    }
Console.WriteLine(+ a2 + " в степени " + b2 + " = " + a);