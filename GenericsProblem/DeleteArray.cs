using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class DeleteArray
    {
        public static void Array()
        {
            object[] mixedArray = { 5, 3.14, 'A', "Hello", 42, 3.14 };

            Console.WriteLine("Original Array:");
            PrintArray(mixedArray);

            // Element to delete (e.g., 'A')
            object elementToDelete = 'A';

            // Call DeleteMethod to remove the specified element
            DeleteArray.DeleteMethod(ref mixedArray, elementToDelete);

            Console.WriteLine("\nArray After Deletion:");
            PrintArray(mixedArray);
        }

        public static void PrintArray(object[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void DeleteMethod(ref object[] array, object elementToDelete)
        {
            array = array.Where(item => !item.Equals(elementToDelete)).ToArray();
        }
    }
}
