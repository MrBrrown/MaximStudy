using System;
namespace MaximStudy
{
	public class ExerciseOne
	{
        // После проведения тестов было выявленно, что при вводе некорретных цифровых значений
        // Программа бросает исключение System.OverflowException
        // При вводе символьных значений программа бросает исключение System.FormatException
        // Для того чтобы программа не прекращала работать каждый ввод обернут в блок try catch
        // Если в момент ввода значения возникает ошибка, переменная хранит в себе значение 0

        private sbyte _sbyte;
		private byte _byte;
		private ushort _ushort;
		private short _short;
		private uint _uint;
		private int _int;
		private long _long;
		private ulong _ulong;

		public void MainLogic()
		{
			while (true)
			{
				string isStop;
				Console.Write("Для выхода введите 1, что бы продолжить введите любое значение: ");
				isStop = Console.ReadLine();
				if (isStop == "1")
					break;

                for (int i = 0; i < 8; i++)
                {
                    try
                    {
                        ValueInput(i);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    ValuePrint(i);
                }
            }
		}

		private void ValueInput(int type)
		{
			switch (type)
			{
				case 0:
					Console.Write("Введите значение для типа дынных sbyte: ");
					_sbyte = sbyte.Parse(Console.ReadLine());
					break;
                case 1:
                    Console.Write("Введите значение для типа дынных byte: ");
                    _byte = byte.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.Write("Введите значение для типа дынных ushort: ");
                    _ushort = ushort.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Введите значение для типа дынных short: ");
                    _short = short.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Введите значение для типа дынных uint: ");
                    _uint = uint.Parse(Console.ReadLine());
                    break;
                case 5:
                    Console.Write("Введите значение для типа дынных int: ");
                    _int = int.Parse(Console.ReadLine());
                    break;
                case 6:
                    Console.Write("Введите значение для типа дынных ulong: ");
                    _ulong = ulong.Parse(Console.ReadLine());
                    break;
                case 7:
                    Console.Write("Введите значение для типа дынных long: ");
                    _long = long.Parse(Console.ReadLine());
                    break;
			}
		}

        private void ValuePrint(int type)
        {
            switch (type)
            {
                case 0:
                    Console.WriteLine("SBYTE: " + _sbyte);
                    break;
                case 1:
                    Console.WriteLine("BYTE: " + _byte);
                    break;
                case 2:
                    Console.WriteLine("USHORT: " + _ushort);
                    break;
                case 3:
                    Console.WriteLine("SHORT: " + _short);
                    break;
                case 4:
                    Console.WriteLine("UINT: " + _uint);
                    break;
                case 5:
                    Console.WriteLine("INT: " + _int);
                    break;
                case 6:
                    Console.WriteLine("ULONG: " + _ulong);
                    break;
                case 7:
                    Console.WriteLine("LONG: " + _long);
                    break;
            }
        }
	}
}

