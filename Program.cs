int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
int target = 1072;
bool found = false;

foreach (int number in recordBooks)
{
    if (number == target)
    {
        found = true;
        break;
    }
}
System.Console.WriteLine(found ? "Студент найден" : "Студент не найден");

int variant = 1;
bool isPrime = true;

for (int divisor = 2; divisor < variant; divisor++)
{
    if (variant == 1)
    {
        System.Console.WriteLine("1 не является ни простым, ни составным числом");
        break;
    }
    if (variant % divisor == 0 && variant != 1)
    {
        isPrime = false;
        break;
    }
}

System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

