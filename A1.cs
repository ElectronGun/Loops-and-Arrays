using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class A1 : MonoBehaviour
{

    // QUESTION 1 - calc sum of all elements in array using sum function
    public int sum(int[] a)   //function sum that takes int array 'a' and returns a int
    {   //begin function
        // YOUR CODE HERE
        int sum = 0;   //initialize int sum to zero
        for (int i = 0; i < a.Length; i++)   //start loop to check all elements of the array 'a'
        {   //begin loop
            sum += a[i];  //adds the value of an element and stores in variable sum
        }   //end of loop
        return sum;   // Calculated sum
    }   //end function

    // QUESTION 2 - find largest integer in array using max function
    public int max(int[] a)    //function max that takes int array 'a' as input and returns a int
    {   //begin function
        // YOUR CODE HERE
        int max = a[0];   //initialize int max to zero
        for (int i = 1; i < a.Length; i++)   //start loop to check all elements except 1st(already assigned to max outside loop) in array 'a'
        {   //begin loop
            if (a[i] > max)  //determine IF current element in array 'a' is greater than max
            {   //begin if
                max = a[i];  //put value of current element in array 'a' to variable max
            }   //end if
        }   //end loop
        return max; // Calculated maximum.
    }

    // QUESTION 3 - Determine average of all odd numbers using oddAvg function
    public float oddAvg(int[] a)   //function oddAvg that takes int array 'a' as input and returns avg of odd numbers in array
    {   //begin function
        // YOUR CODE HERE
        float sum = 0;   //initialize int sum to zero - sum to determine average
        float count = 0;   //initialize int count to zero - # of elements to average
        for (int i = 0; i < a.Length; i++)   //start loop to check all elements in array 'a'
        {   //begin loop
            if (a[i] % 2.0f != 0)  //divide, decide if not equal - divide current element by 2 and check that not equal to zero
            {   //begin if
                sum += a[i];   //adds the value in element and stores in variable sum
                count++;   //increment variable count
            }   //end if
        }   //end loop
        return sum / count; // Calculated average of all odd numbers in array. 
    }

    // QUESTION 4 - determine output which is reverse of input array using reverse function
    public int[] reverse(int[] a)   //function reverse that takes array 'a' as input and returns a int
    {   //begin function
        // YOUR CODE HERE
        int[] output = new int[a.Length];   //initialize int array output with same length and input array 'a'
        for (int i = 0; i < a.Length; i++)   //start loop to check all elements in array 'a'
        {   //begin loop
            output[i] = a[a.Length - 1 - i];  //calc position from end of input array 'a' using current element value and place into new array 'output'
        }   //end loop
        return output;  //return reverse array of same length as input
    }

    // QUESTION 5 - take function
    public int[] take(int[] a, int n)   //function take that considers int array 'a' and int 'n' as inputs and returns a new array 'output'
    {   //begin function
        // YOUR CODE HERE
        if (n <= 0 || n > a.Length)  // check n<=0, n>length of array 'a'. if either true then both true
        {   //begin if
            return a;   //returns orig array 'a' if either true
        }   //end if
        else   //if neither true then create new int array 'output' with size = n
        {   //begin else
            int[] output = new int[n];   // initialize new int array 'output' with size determined by 'n' input
            for (int i = 0; i < n; i++) //start loop to check all elements in array 'a' up to n-1(the last element)
            {   //begin loop
                output[i] = a[i];   //put value of current element in array 'a' to new array 'output' 
            }   //end loop
            return output;  //return output array with 1st n elements of array 'a'
        }  //end else
    }

    // BONUS QUESTION - Bubble Sort
    public int[] sort(int[] a)   //function sort that takes array 'a' as input and returns a int array
    {   //begin function
        // YOUR CODE HERE
        int[] output = new int[a.Length];   //initialize new int array 'output' with same size as input array 'a'
        for (int i = 0; i < a.Length - 1; i++)   //start loop to check all elements in array 'a' except last element, increment loop i 
        {   //begin loop
            for (int j = 0; j < a.Length - i - 1; j++)   //start loop 2 to check all elements up to a.Length-2, increment loop j
            {   //begin loop 2
                if (a[j] > a[j + 1])   //check current element and compare to next element in array 'a'
                {   //begin if
                    int temp = a[j];   //assign value of current element to temp variable
                    a[j] = a[j + 1];   //assign value of next element in array to current element (swap positions)
                    a[j + 1] = temp;   //assign temp to next element in array
                }   //end if
            }   //end loop 2
        }   //end loop 1
        output = a;   //put sorted input array 'a' to variable output
        return output;   //return sorted array
    }


    // Start is called before the first frame update
    void Start()
    {
        int[] array1 = { 1, 1, 3, 4, 5 };
        int[] array2 = { 49, 42, 34, 29, 98, 40, 24, 70, 90, 78 };
        int[] array3 = { 10,43,25,11,2,68,77,84,99,50
                      ,5,53,86,23,79,1,74,20,18,32
                      ,89,69,21,59,49,12,14,98,71,7
                      ,85,19,4,66,38,37,15,92,44,75
                      ,67,81,30,27,29,26,46,96,47,87
                      ,13,94,52,58,33,9,35,3,57,82,73
                      ,70,54,78,63,45,93,91,65,62,80
                      ,64,90,24,34,88,22,36,6,42,76
                      ,17,72,8,97,55,39,95,16,60,56
                      ,40,100,61,28,31,41,48,83,51};

        Debug.Log("array 1 sum = " + sum(array1) + " (expected 14)");
        Debug.Log("array 2 sum = " + sum(array2) + " (expected 554)");
        Debug.Log("array 3 sum = " + sum(array3) + " (expected 5050)");

        Debug.Log("array 1 max = " + max(array1) + " (expected 5)");
        Debug.Log("array 2 max = " + max(array2) + " (expected 98)");
        Debug.Log("array 3 max = " + max(array3) + " (expected 100)");

        Debug.Log("array 1 oddAvg = " + oddAvg(array1) + " (expected 2.5)");
        Debug.Log("array 2 oddAvg = " + oddAvg(array2) + " (expected 39)");
        Debug.Log("array 3 oddAvg = " + oddAvg(array3) + " (expected 50)");

        Debug.Log("array 1 reverse = {" + string.Join(",", reverse(array1)) + "}");
        Debug.Log("(expecting {5,4,3,1,1})");

        Debug.Log("array 2 reverse = {" + string.Join(",", reverse(array2)) + "}");
        Debug.Log("(expecting {78,90,70,24,40,98,29,34,42,49})");

        Debug.Log("array 3 reverse = {" + string.Join(",", reverse(array3)) + "}");
        Debug.Log("(expecting {51,83,48,41,31,28,61,100,40,56,60,16,95,39,55,97,8,72,17,76,42,6,36,22,88,34,24,90,64,80,62,65,91,93,45,63,78,54,70,73,82,57,3,35,9,33,58,52,94,13,87,47,96,46,26,29,27,30,81,67,75,44,92,15,37,38,66,4,19,85,7,71,98,14,12,49,59,21,69,89,32,18,20,74,1,79,23,86,53,5,50,99,84,77,68,2,11,25,43,10} )");

        Debug.Log("array 1 take 3 = {" + string.Join(",", take(array1, 3)) + "}");
        Debug.Log("(expecting {1,1,3})");

        Debug.Log("array 1 take 10 = {" + string.Join(",", take(array1, 10)) + "}");
        Debug.Log("(expecting {1,1,3,4,5})");

        Debug.Log("array 2 take 5 = {" + string.Join(",", take(array2, 5)) + "}");
        Debug.Log("(expecting  {49,42,34,29,98})");

        Debug.Log("array 3 take 14 = {" + string.Join(",", take(array3, 14)) + "}");
        Debug.Log("(expecting {10,43,25,11,2,68,77,84,99,50,5,53,86,23} )");

        Debug.Log("array 1 sort = {" + string.Join(",", sort(array1)) + "}");
        Debug.Log("(expecting {1,1,3,4,5})");

        Debug.Log("array 2 sort = {" + string.Join(",", sort(array2)) + "}");
        Debug.Log("(expecting {24,29,34,40,42,49,70,78,90,98})");

        Debug.Log("array 3 sort = {" + string.Join(",", sort(array3)) + "}");
        Debug.Log("(expecting {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100} )");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
