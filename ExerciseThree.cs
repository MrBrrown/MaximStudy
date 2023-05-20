using System;
namespace MaximStudy
{
	public class ExerciseThree
	{
        private double accuarcy;    // Точность
        private int n;  // Колличество членов ряда

		public ExerciseThree(double _accuarcy)
		{
            accuarcy = _accuarcy;
            n = 1;
		}

        public double GetE()
        {
            // Формула e = sum(1/i!)
            // Начнем расчет сразу со второго члена, так как 1/0! = 1
            double e = 1;
            double sumMember = 0;   // Очередной член ряда
            double numerator = 1;   // Числитель в формуле
            double denomirator = 1; // Знаменатель в формуле

            do
            {
                denomirator *= n;
                n++;
                sumMember = numerator / denomirator;
                e += sumMember;
            }
            while (sumMember > accuarcy);

            return e;
        }

        public int GetCountOfMembers()
        {
            return n;
        }
    }
}

