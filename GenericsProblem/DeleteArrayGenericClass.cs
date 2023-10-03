using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    public class DeleteArrayGenericClass<T>
    {
        public void DeleteMethod(ref T[] array, T elementToDelete)
        {
            array = array.Where(item => !item.Equals(elementToDelete)).ToArray();
        }
    }
    public class Generic
    {
        public static void ArrayGenerics()
        {
            object[] mixedArray = { 5, 3.14, 'A', "Hello", 42, 3.14 };

            Console.WriteLine("Original Array:");
            DeleteArray.PrintArray(mixedArray);

            // Element to delete (e.g., 'A')
            char elementToDelete = 'A';

            // Create an instance of DeleteArray<char>
            DeleteArrayGenericClass<object> deleter = new DeleteArrayGenericClass<object>();
            deleter.DeleteMethod(ref mixedArray, elementToDelete);

            Console.WriteLine("\nArray After Deletion:");
            DeleteArray.PrintArray(mixedArray);
        }
    }
}
