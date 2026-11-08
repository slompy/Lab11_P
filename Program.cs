// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1072;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// System.Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 2;
// bool isPrime = true;

// for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0 && variant != 1)
//     {
//         isPrime = false;
//         break;
//     }
// }

// if (variant == 1)
// {
//     System.Console.WriteLine("1 не является ни простым, ни составным числом");
// }
// else
// {
//     System.Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// }

int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
int sum = 0;
int count = 1;

foreach (int points in pointsPerLab)
{
    if (points < 0)
    {
        continue;
    }
    else
    {
        count++;
    }
    sum += points;
}

System.Console.WriteLine($"Всего работ сдано: {count}");
System.Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
System.Console.WriteLine();


int[] groupIds = { 101, 104, 107, 104, 110 };
bool hasDuplicates = false;

for (int i = 0; i < groupIds.Length; i++)
{
    for (int j = i + 1; j < groupIds.Length; j++)
    {
        if (groupIds[i] == groupIds[j])
        {
            hasDuplicates = true;
            System.Console.WriteLine($"Совпавшие номера: {groupIds[i]} и {groupIds[j]}");
            break;
        }
    }
}

System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");
System.Console.WriteLine();