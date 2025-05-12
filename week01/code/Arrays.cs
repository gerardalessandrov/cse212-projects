using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client.Payloads;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
      
      double[] result=new double[length];
   // double[] represents an array, what follows is the name of that array, the equality implies that it is new and that
// it will have length as an index which is a variable of our function
// we establish a loop with its variable i that starts from zero, the condition 0 < length - quantity of stable elements
// in the function, that is, it will go through those items, if it is true that i is less than the quantity, it is added,
// the loop ends when i is greater than the number of items.
     for (int i=0;i<length;i++){
        result[i]=number*(i+1);
     }
   // result is the array i is equal to the index or position of each item in the array will start from 0
   // and will then increase the number that we want to find the multiple will multiply
   // i from 0 until it reaches the number of items then the loop will end


        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        return result;
      
      
         // replace this return statement with your own
    }
    

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        int count = data.Count;
        // Initialize the count variable that will count the data list
        // Copy the amount elements
        // Copy the last 'amount' elements
        List<int> temp = data.GetRange(count - amount, amount);

    // Remove the last 'amount' elements
       data.RemoveRange(count - amount, amount);

   // Insert them at the beginning
       data.InsertRange(0, temp);
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be
        //  implemented by another person.
    }
    
}
