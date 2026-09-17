using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {

                int minIndex = i;
                for (int j = i+1; j<n;j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;

                    }
                }

                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);

            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {

            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    { 

                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    
                    
                    }
                
                
                }
            
            
            }




            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            
            }





            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j+1] = numbers[j];
                    j--;
                
                }
                numbers[j + 1] = key;
            
            
            
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);

            }



            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                (numbers[i], numbers[maxIndex]) = (numbers[maxIndex], numbers[i]);
            }

            foreach (var _n in numbers)
            { 

                Debug.Log(_n);


            }


            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int n = numbers.Length;


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }


            foreach (var _n in numbers)
            {
                Debug.Log(_n);
            }


            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {

            int n = numbers.Length;

            for (int i = 1; i < n; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                
                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }

            foreach (var _n in numbers)
            {
                Debug.Log(_n);
            }

            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);

            int largest = numbers[0];
            int secondLargest = int.MinValue;
            bool found = false;


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < largest)
                {
                    secondLargest = numbers[i];
                    found = true;
                    break;
                }
            }

            if (found)
            { 
                Debug.Log(secondLargest);
                return secondLargest;
            }
            else
            {
                Debug.Log("No second largest number found.");
                return int.MinValue;


            }


            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            return 0;
        }

        #endregion
    }
}
