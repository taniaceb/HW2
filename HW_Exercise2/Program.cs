using System;

namespace HW_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array, array2;
            array = NumberChangeToArray(745931);
            array2 = NumberChangeToArray(593176);
            Console.WriteLine("Ar du array sutama:" + CheckTwoArrayElement(array, array2)); 

            Console.WriteLine(CheckIsNumberDifferent(array));
            //SortArrayElement(array);


            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            for (int i = 100000; i < 999999; i++)
            {
                if ( ((i *= 2) < 999999) && ((i *= 3) < 999999) && ((i *= 4) < 999999) && ((i *= 5) < 999999) && ((i *= 6) < 999999))
                {
                    NumberChangeToArray(i);

                }

            }

        }

        



        static int[] NumberChangeToArray(int number)
        {

            int[] array = new int[6];

            int j = 5;

            for (int i = 0; i < 6; i++)
            {

                array[j] = number % 10;
                number = number / 10;
                j--;
            }
            return array;

        }

        static bool CheckIsNumberDifferent(int[] array)
        {
            bool result = true;
            for (int i = 0; i < 5; i++)
            {

                for (int j = i + 1; j < 6; j++)
                {
                    if (array[i] == array[j])
                    {
                        result = false;
                        break;
                    }

                }

            }
            return result;
        }

        static void SortArrayElement(int[] array)

        {
            int tmp = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)

                {
                    if (array[i] > array[j])
                    {
                        tmp = array[j];
                        array[j] = array[i];
                        array[i] = tmp;

                    }
                }

            }

        }



        static bool CheckTwoArrayElement(int[] array1, int[] array2)
        {
            int[] temp1, temp2;
            bool result = true;

            temp1 = (int[])array1.Clone();
            temp2 = (int[])array2.Clone();
            SortArrayElement(temp1);
            SortArrayElement(temp2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (temp1[i] != temp2[i])
                {
                    result = false;
                    break;
                }
            }

            return result;

        }

    }
}
