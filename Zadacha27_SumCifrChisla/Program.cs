Console.Clear();
Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int sum = 0;
foreach (var item in number)
{
    sum += Convert.ToInt32(item.ToString());
}
Console.WriteLine("Ответ:" +sum);