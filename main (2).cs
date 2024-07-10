/******************************************************************************
you have a list of integers {1,2,2,4,6,3,6,0,2} -? {2,6}

make a function that returns a list of integers that's appeared more than once
*******************************************************************************/

using System;
 using System.Collections.Generic;
class  Duplicates{
  static void Main() {
      List<int> numbers = new List<int> { 1, 2, 2, 4, 6, 3, 6, 0, 2 };
        List<int> duplicates = FindDuplicates(numbers);
        
        Console.Write("Duplicates: ");
        foreach (int duplicate in duplicates)
        {
            Console.Writeline(duplicate + " ");
        }
    }
     public static List<int> FindDuplicates(List<int> numbers)
    {
         Dictionary<int, int> count = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();

        foreach (int number in numbers)
        {
            if (count.ContainsKey(number))
            {
                count[number]++;
            }
            else
            {
                count[number] = 1;
            }
        }
        foreach (int k in count.Keys)
        {
            if (count[k] > 1)
            {
                duplicates.Add(k);
            }
        }

        return duplicates;
    }
        
  
}