Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

int digit1 = number / 10; 
int digit2 = number % 10;
int digit3 = digit1 % 10;

int result = digit1 * 10 + digit2;

if (number >= 0 && number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (digit1 < 999)

Console.WriteLine($"Вторая цифра из {number} -> {digit3}");
