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


using System.Text.RegularExpressions;

// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 1;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     else
//     {
//         count++;
//     }
//     sum += points;
// }

// System.Console.WriteLine($"Всего работ сдано: {count}");
// System.Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// System.Console.WriteLine();


// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             System.Console.WriteLine($"Совпавшие номера: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
// }

// System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");
// System.Console.WriteLine();

// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree)
//         {
//             System.Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found)
// {
//     System.Console.WriteLine("Свободный слотов нет");
// }

// Задача А
int[] numburs = { 100, 10, 1000, 500, 67 };
int correctNumbur = 50;
bool correct = false;

foreach (int numbur in numburs)
{
    if (numbur == correctNumbur)
    {
        System.Console.WriteLine($"Число найдено: {correctNumbur}");
        correct = true;
        break;
    }
}

if (correct == false)
{
    System.Console.WriteLine("Число не найдено");
}

// Задача Г
int[] numbars = { 50, 50, 40, 41, 42, 42, 42, 43, 42, 43 };
bool hasDuplicates = false;

for (int i = 0; i < numbars.Length; i++)
{
    for (int j = i + 1; j < numbars.Length; j++)
    {
        if (numbars[i] == numbars[j])
        {
            hasDuplicates = true;
            System.Console.WriteLine($"Совпавшие номера: {numbars[i]} и {numbars[j]}");
            continue;
        }
    }
}

System.Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");
System.Console.WriteLine();