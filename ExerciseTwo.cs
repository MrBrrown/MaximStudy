using System;
namespace MaximStudy
{
	public class ExerciseTwo
	{
        private int[] array;

        public ExerciseTwo(int[] _array)
        {
            array = _array;
        }

        public int LinearSearch(int valueToSearch)
        {
            int indexOfSearchedValue = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valueToSearch)
                {
                    indexOfSearchedValue = i;
                    return indexOfSearchedValue;
                }
            }
            return indexOfSearchedValue;
        }

        // Поиск с барьером используется в случае, когда мы уверены, что искомый эллемент есть в массиве
        // Это условие может осуществяться как на стороне пользователя, так и на стороне программиста
        // Искомое значение и называется барьером
        // НИже предсавлена реализация функции с контролем на стороне программиста
        public int LinearBarrierSearch(int valueToSearch)
        {
            int indexOfSearchedValue = 0;
            var last = array.Last();
            array[array.Length - 1] = valueToSearch; // Обеспечивание нахождение искомого элемента в массиве

            while (array[indexOfSearchedValue] != valueToSearch)
            {
                indexOfSearchedValue++;
            }

            array[array.Length - 1] = last;
            if (indexOfSearchedValue == array.Length - 1 && valueToSearch != last)
            {
                return -1;
            }
            else
            {
                return indexOfSearchedValue;
            }
        }

        // Предназначен только для отсортированных массивов данных
        // Поэтому перед началом алгоритма произведем сортировку массива
        public int BinarySearch(int valueToSearch)
		{
            int indexOfSearchedValue = -1;
            var sortedArray = array;
            Array.Sort(sortedArray);

            var left = 0;
            var right = sortedArray.Length - 1;

            while (left <= right)
            {
                var middle = left + (right - left) / 2;

                if (sortedArray[middle] == valueToSearch)
                {
                    indexOfSearchedValue = middle;
                    return indexOfSearchedValue;
                }
                else if (valueToSearch > sortedArray[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            return indexOfSearchedValue;
		}
	}
}

