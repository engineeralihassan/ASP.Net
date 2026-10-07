namespace ArraysSpace
{
    class ArraysClass
    {
        static void arrays(string[] args)
        {
            // Arrays in C#
           // An array is a linear data structure that stores a fixed-size sequence of elements of the same data type in contiguous memory locations. It allows accessing elements using an index, starting from 0.
           // declares an Array of integers.
           int[] intArray;

           // allocating memory for 5 integers.
           intArray = new int[5];

           // initialize the first elements of the array
           intArray[0] = 10;

           // initialize the second elements of the array
           intArray[1] = 20;

           // so on...
           intArray[2] = 30;
           intArray[3] = 40;
           intArray[4] = 50;

           // accessing the elements using for loop
           Console.Write("For loop :");
           for (int i = 0; i < intArray.Length; i++)
               Console.Write(" " + intArray[i]);

           Console.WriteLine("");
           Console.Write("For-each loop :");
		
           // using for-each loop
           foreach(int i in intArray)
               Console.Write(" " + i);

           Console.WriteLine("");
           Console.Write("while loop :");
		
           // using while loop
           int j = 0;
           while (j < intArray.Length) {
               Console.Write(" " + intArray[j]);
               j++;
           }

           Console.WriteLine("");
           Console.Write("Do-while loop :");
		
           // using do-while loop
           int k = 0;
           do
           {
               Console.Write(" " + intArray[k]);
               k++;
           } while (k < intArray.Length);
           
           // Types of Arrays in C#
           // There are three types of Arrays C# supports as mentioned below:
           // declares a 1D Array of string.
           string[] weekDays;

           // allocating memory for days.
           weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

           // Displaying Elements of array
           foreach(string day in weekDays)
               Console.Write(day + " ");
           
           
           // The same array with dimensions specified 2, 2 and 3.
           int[,, ] arr2 = new int[2, 2, 3] { { { 1, 2, 3 }, 
                   { 4, 5, 6 } }, 
               { { 7, 8, 9 }, 
                   { 10, 11, 12 } } };

           // Checking elements at particular index
           Console.WriteLine("arr[1][0][1] : " + arr2[1, 0, 1]);
							
           Console.WriteLine("arr[1][1][2] : " + arr2[1, 1, 2]);
           
           // Multidimensional Arrays in C#
           // Array Initialized and Declared
           int[, ] arr1 = { { 1, 2 }, { 3, 4 } };

           Console.WriteLine("Elements of Arrays:");

           // Iterating the Elements of Array
           for (int i1 = 0; i1 < arr1.GetLength(0); i1++) {
               for (int j1 = 0; j1 < arr1.GetLength(1); j1++) {
                   // Console.Write(arr[i1, j1] + " ");
               }
               Console.WriteLine();
           }
           
           
           // Jagged Arrays in C#
           // A jagged array is an array of arrays, where each element is itself an array that can have a different length. Rows are fixed at declaration, but columns can vary. It can also combine with multidimensional arrays.
           
           int[][] jaggedArr = new int[3][];

          // Initialize each row with different lengths
           jaggedArr[0] = new int[] { 1, 2, 3 };
           jaggedArr[1] = new int[] { 4, 5 };
           jaggedArr[2] = new int[] { 6, 7, 8, 9 };
           
           // Declaration of a jagged array with 3 rows
           int[][] arr = new int[3][];
        
           // Initializing each row of the jagged array First row
           arr[0] = new int[] { 1, 2, 3, 4}; 
      
           // Second row
           arr[1] = new int[] { 4, 5, 6 }; 
      
           // Third row (only two elements)
           arr[2] = new int[] { 7, 8 };    

           // Accessing the third element in second row
           int value = arr[1][2]; 
        
           // Modifying the second element in the first row (from 2 to 10)
           arr[0][1] = 10; 
        
           // Outputting the modified value
           Console.WriteLine(arr[0][1]);  

           // Outputting the accessed value for verification
           Console.WriteLine("Accessed value: " + value);
           
           // Array Class in C#
           
           
           
           
           
        }
        

        
    }
}