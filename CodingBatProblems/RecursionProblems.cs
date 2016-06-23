using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatProblems
{
    class RecursionProblems
    {


        //Given n of 1 or more, return the factorial of n, which is n* (n-1) * (n-2) ... 1. Compute the result recursively(without loops).
        //factorial(1) → 1
        //factorial(2) → 2
        //factorial(3) → 6

        public int factorial(int n)
        {
            //Base Case 
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }


        }


        //We have a number of bunnies and each bunny has two big floppy ears.
        //We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
        //bunnyEars(0) → 0
        //bunnyEars(1) → 2
        //bunnyEars(2) → 4

        public int bunnyEars(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return 2 + bunnyEars(n - 1);
            }

        }

        //The fibonacci sequence is a famous bit of mathematics, and it happens to have a recursive definition.
        //The first two values in the sequence are 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the previous two values,
        //so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21 and so on.Define a recursive fibonacci(n) method that returns the nth fibonacci number, 
        //with n = 0 representing the start of the sequence.
        //fibonacci(0) → 0
        //fibonacci(1) → 1
        //fibonacci(2) → 1

        public int fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }

        //We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies(1, 3, ..) have the normal 2 ears.
        //The even bunnies(2, 4, ..) we'll say have 3 ears, because they each have a raised foot. 
        //Recursively return the number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
        //bunnyEars2(0) → 0
        //bunnyEars2(1) → 2
        //bunnyEars2(2) → 5

        public int bunnyEars2(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 2;
            }
            else
            {

                return 5 + bunnyEars2(n - 2);

            }
        }

        //We have triangle made of blocks.The topmost row has 1 block, the next row down has 2 blocks, the next row has 3 blocks, and so on.
        //Compute recursively (no loops or multiplication) the total number of blocks in such a triangle with the given number of rows.
        //triangle(0) → 0
        //triangle(1) → 1
        //triangle(2) → 3

        public int triangle(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + triangle(n - 1);
            }
        }

        //Given a non-negative int n, return the sum of its digits recursively(no loops). 
        //Note that mod(%) by 10 yields the rightmost digit(126 % 10 is 6), while divide(/) by 10 removes the rightmost digit(126 / 10 is 12).
        //sumDigits(126) → 9
        //sumDigits(49) → 13
        //sumDigits(12) → 3

        public int sumDigits(int n)
        {
            if (n > 0)
            {
                return (n % 10) + sumDigits(n / 10);
            }
            else
            {
                return 0;

            }
        }
        //Given a non-negative int n, return the count of the occurrences of 7 as a digit, so for example 717 yields 2. (no loops). 
        //Note that mod(%) by 10 yields the rightmost digit(126 % 10 is 6), while divide(/) by 10 removes the rightmost digit(126 / 10 is 12).
        //count7(717) → 2
        //count7(7) → 1
        //count7(123) → 0 

        public int count7(int n)
        {
            //base case
            if (n == 0)
                return 0;
            //if the right most digit is 7 add one to the output. 
            if (n % 10 == 7)
                return 1 + count7(n / 10);
            
            //if the right most digit is not 7, don't add one to the output and recursively call the method again.  
            return count7(n / 10);

        }

        //Given a non-negative int n, compute recursively(no loops) the count of the occurrences of 8 as a digit, except that an 8 with another 8 immediately to its left counts double, so 8818 yields 4. 
        //Note that mod(%) by 10 yields the rightmost digit(126 % 10 is 6), while divide(/) by 10 removes the rightmost digit(126 / 10 is 12).
        //count8(8) → 1
        //count8(818) → 2
        //count8(8818) → 4

        public int count8(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n % 10 == 8)
            {
                if ((n / 10) % 10 == 8)
                    return 2 + count8(n / 10);

                return 1 + count8(n / 10);
            }
            else
            {
                return count8(n / 10);
            }


        }

        //Given base and n that are both 1 or more, compute recursively(no loops) the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
        //powerN(3, 1) → 3
        //powerN(3, 2) → 9
        //powerN(3, 3) → 27

        public int powerN(int b, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return b;
            }
            else
            {
                return b * powerN(b, n - 1);
            }
        }

        //Given a string, compute recursively(no loops) the number of lowercase 'x' chars in the string.
        //countX("xxhixx") → 4
        //countX("xhixhix") → 3
        //countX("hi") → 0

        public int countX(String str)
        {

            if (str.Length == 0)
            {
                return 0;
            }
            else if (str[0] == 'x')
            {
                return 1 + countX(str.Substring(1));
            }
            else
            {
                return countX(str.Substring(1));
            }
        }


        //Given a string, compute recursively(no loops) the number of times lowercase "hi" appears in the string.
        //countHi("xxhixx") → 1
        //countHi("xhixhix") → 2
        //countHi("hi") → 1

        public int countHi(String str)
        {

            if (str.Length == 0)
                return 0;
            if (str.Length == 1)
                return 0;

            if (str[0] == 'h' && str[1] == 'i')
                return 1 + countHi(str.Substring(2));

            return countHi(str.Substring(1));
        }

        // Given a string, compute recursively(no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.
        //changeXY("codex") → "codey"
        //changeXY("xxhixx") → "yyhiyy"
        //changeXY("xhixhix") → "yhiyhiy"

        public String changeXY(String str)
        {

            if (str.Length == 0)
            {
                return str;
            }
            else if (str[0] == 'x')
            {
                return "y" + changeXY(str.Substring(1));
            }
            else
            {
                return str[0] + changeXY(str.Substring(1));
            }  

                     
          

        }

        //Given a string, compute recursively(no loops) a new string where all appearances of "pi" have been replaced by "3.14".
        //changePi("xpix") → "x3.14x"
        //changePi("pipi") → "3.143.14"
        //changePi("pip") → "3.14p"

        public String changePi(String str)
        {

            if (str.Length == 0)
                return str;
            if (str.Length == 1)
                return str;
            if (str[0] == 'p' && str[1] == 'i')
                return "3.14" + changePi(str.Substring(2));

            return str[0] + changePi(str.Substring(1));



        }

        //Given a string, compute recursively a new string where all the 'x' chars have been removed.
        //noX("xaxb") → "ab"
        //noX("abc") → "abc"
        //noX("xx") → ""

        public String noX(String str)
        {
            if (str.Length == 0)
                return str;
            if (str[0] == 'x')
                return noX(str.Substring(1));

            return str[0] + noX(str.Substring(1));

        }

        //Given an array of ints, compute recursively if the array contains a 6. We'll use the convention of considering only the part of the array that begins at the given index. In this way, a recursive call can pass index+1 to move down the array. The initial call will pass in index as 0.
        //array6([1, 6, 4], 0) → true
        //array6([1, 4], 0) → false
        //array6([6], 0) → true

        public bool array6(int[] nums, int index)
        {

            if (nums.Length == 0)
                return false;


            if (nums[index] == 6)
                return true;

            if (index != nums.Length - 1)
                return array6(nums, index + 1);

            return false;
        }

        //Given an array of ints, compute recursively the number of times that the value 11 appears in the array.We'll use the convention of considering only the part of the array that begins at the given index. In this way, a recursive call can pass index+1 to move down the array. The initial call will pass in index as 0.
        //array11([1, 2, 11], 0) → 1
        //array11([11, 11], 0) → 2
        //array11([1, 2, 3, 4], 0) → 0

        public int array11(int[] nums, int index)
        {

            if (nums.Length == 0)
                return 0;

            if (!(index > nums.Length - 1))
            {
                if (nums[index] == 11)
                    return 1 + array11(nums, index + 1);

                return array11(nums, index + 1);
            }
            return 0;
        }

        //Given an array of ints, compute recursively if the array contains somewhere a value followed in the array by that value times 10. We'll use the convention of considering only the part of the array that begins at the given index. In this way, a recursive call can pass index+1 to move down the array. The initial call will pass in index as 0.
        //array220([1, 2, 20], 0) → true
        //array220([3, 30], 0) → true
        //array220([3], 0) → false
        public bool array220(int[] nums, int index)
        {
            
            if (index < nums.Length - 1)
            {
                if (nums[index] * 10 == nums[index + 1])
                    return true;

                return array220(nums, index + 1);
            }

            return false;




        }

        //Given a string, compute recursively a new string where all the adjacent chars are now separated by a "*".
        //allStar("hello") → "h*e*l*l*o"
        //allStar("abc") → "a*b*c"
        //allStar("ab") → "a*b
        public String allStar(String str)
        {
         
            if (str.Length > 1)
                return str[0] + "*" + allStar(str.Substring(1));

            return str;
        }

        //Given a string, compute recursively a new string where identical chars that are adjacent in the original string are separated from each other by a "*".
        //pairStar("hello") → "hel*lo"
        //pairStar("xxyy") → "x*xy*y"
        //pairStar("aaaa") → "a*a*a*a"
        public String pairStar(String str)
        {

            if (str.Length < 2)
                return str;


            if (str[0] == str[1])
                return str[0] + "*" + pairStar(str.Substring(1));

            return str[0] + pairStar(str.Substring(1));

        }

    }
}
