using MaximStudy;

while (true)
{
    Console.WriteLine("Выберите сценарий программы: 1 - первое задание, 2 - второе задание, 3 - третье задание");
    Console.WriteLine("Для выхода введите 0");
    int programScenario = int.Parse(Console.ReadLine());

    switch (programScenario)
    {
        case 0:
            return;
        case 1:
            ExerciseOne exerciseOne = new();
            exerciseOne.MainLogic();

            Console.WriteLine();
            break;
        case 2:
            int[] ints = { 10, 12, 65, 56, 78, 2, 3, 5, 6, 4, 674, 45632, 34, 5, 6, 8, 9, 9, 3, 2, 12, 33, 56, 78 };
            ExerciseTwo exerciseTwo = new(ints);

            Console.WriteLine("Линейный поиск: " + exerciseTwo.LinearSearch(56));
            Console.WriteLine("Линейный поиск c барьером: " + exerciseTwo.LinearBarrierSearch(3));
            Console.WriteLine("Бинарный поиск: " + exerciseTwo.BinarySearch(78));

            Console.WriteLine();
            break;
        case 3:
            Console.WriteLine("Введите нужную точность (пример: 0.00001): ");
            double accuarcy = double.Parse(Console.ReadLine());
            ExerciseThree exerciseThree = new(accuarcy);

            Console.WriteLine("Значение Е в классе Math:" + Math.E);
            Console.WriteLine("Полученное значение Е: " + exerciseThree.GetE());
            Console.WriteLine("Точность числа - {0}\nКолличесво членов для дотижения данной точности - {1}", accuarcy, exerciseThree.GetCountOfMembers());

            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Неверный ввод, повторите попытку");

            Console.WriteLine();
            break;
    }
}

