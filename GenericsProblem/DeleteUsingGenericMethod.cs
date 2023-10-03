using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class DeleteUsingGenericMethod
    {
        public static void ArrayGeneric()
        {
            object[] mixArray = { 5, 3.14, 'A', "Hello", 42, 3.14 };

            Console.WriteLine("Original Array:");
            DeleteArray.PrintArray(mixArray);

            // Element to delete (e.g., 'A')
            char elementToDelete = 'A';

            // Call DeleteMethod to remove the specified element
            DeleteUsingGenericMethod.DeleteGenMethod(ref mixArray, elementToDelete);

            Console.WriteLine("\nArray After Deletion:");
            DeleteArray.PrintArray(mixArray);
        }
        public static void DeleteGenMethod<T>(ref T[] array, T elementToDelete)
        {
            array = array.Where(item => !item.Equals(elementToDelete)).ToArray();
        }
    }
}
