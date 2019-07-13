using System;

namespace HW_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array, array2, array3, array4, array5, array6;
            int j, k, l, m, n;
                        

            for (int i = 100000; i < 999999; i++)
            {
                j = i * 2;
                k = i * 3;
                l = i * 4;
                m = i * 5;
                n = i * 6;
                

                
                if ( (j < 999999) && (k < 999999) && (l < 999999) && (m < 999999) && (n < 999999))
                {
                    
                    array = NumberChangeToArray(i);
                    if (CheckIsNumberDifferent(array))
                    {
                        
                        array2 = NumberChangeToArray(j);
                        
                        array3 = NumberChangeToArray(k);
                        
                        array4 = NumberChangeToArray(l);
                        
                        array5 = NumberChangeToArray(m);
                        
                        array6 = NumberChangeToArray(n);

                        if (CheckTwoArrayElement(array, array2) && CheckTwoArrayElement(array, array3) && CheckTwoArrayElement(array, array4) && CheckTwoArrayElement(array, array5) && CheckTwoArrayElement(array, array6))
                        {
                            Console.WriteLine("MAGIC NUMBER IS:  " + i );
                            Console.WriteLine("*2:  " + j);
                            Console.WriteLine("*3:  " + k);
                            Console.WriteLine("*4:  " + l);
                            Console.WriteLine("*5:  " + m);
                            Console.WriteLine("*6:  " + n);
                        }
                    }
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
