/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINATION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ISM6225_Assignment_2_Spring_2022
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Question 1:
            //Console.WriteLine("Question 1:");
            //int[] nums1 = { 0, 1, 2, 3, 12 };
            //Console.WriteLine("Enter the target number:");
            //int target = Int32.Parse(Console.ReadLine());
            //int pos = SearchInsert(nums1, target);
            //Console.WriteLine("Insert Position of the target is : {0}", pos);
            //Console.WriteLine("");

            ////Question2:
            //Console.WriteLine("Question 2");
            //string paragraph =  "Bob hit a ball, the hit BALL flew far after it was hit.";

            //string[] banned = { "hit" };
            //string commonWord = MostCommonWord(paragraph, banned);
            //Console.WriteLine("Most frequent word is {0}:", commonWord);
            //Console.WriteLine();

            ////Question 3:
            //Console.WriteLine("Question 3");
            //int[] arr1 = { 2, 2, 3, 4 };
            //int lucky_number = FindLucky(arr1);
            //Console.WriteLine("The Lucky number in the given array is {0}", lucky_number);
            //Console.WriteLine();

            ////Question 4:
            //Console.WriteLine("Question 4");
            //string secret = "1807";
            //string guess = "7810";
            //string hint = GetHint(secret, guess);
            //Console.WriteLine("Hint for the guess is :{0}", hint);
            //Console.WriteLine();


            //Question 5:
            Console.WriteLine("Question 5");
            string s = "ababcbacadefegdehijhklij";
            List<int> part = PartitionLabels(s);
            Console.WriteLine("Partation lengths are:");
            for (int i = 0; i < part.Count; i++)
            {
                Console.Write(part[i] + "\t");
            }
            Console.WriteLine();

            ////Question 6:
            //Console.WriteLine("Question 6");
            //int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            //string bulls_string9 = "abcdefghijklmnopqrstuvwxyz";
            //List<int> lines = NumberOfLines(widths, bulls_string9);
            //Console.WriteLine("Lines Required to print:");
            //for (int i = 0; i < lines.Count; i++)
            //{
            //    Console.Write(lines[i] + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //Question 7:
            Console.WriteLine("Question 7:");
            string bulls_string10 = "()[]{}";
            bool isvalid = IsValid(bulls_string10);
            if (isvalid)
                Console.WriteLine("Valid String");
            else
                Console.WriteLine("String is not Valid");

            Console.WriteLine();
            Console.WriteLine();


            ////Question 8:
            //Console.WriteLine("Question 8");
            //string[] bulls_string13 = { "gin", "zen", "gig", "msg" };
            //int diffwords = UniqueMorseRepresentations(bulls_string13);
            //Console.WriteLine("Number of with unique code are: {0}", diffwords);
            //Console.WriteLine();
            //Console.WriteLine();

            ////Question 9:
            //Console.WriteLine("Question 9");
            //int[,] grid = { { 0, 1, 2, 3, 4 }, { 24, 23, 22, 21, 5 }, { 12, 13, 14, 15, 16 }, { 11, 17, 18, 19, 20 }, { 10, 9, 8, 7, 6 } };
            //int time = SwimInWater(grid);
            //Console.WriteLine("Minimum time required is: {0}", time);
            //Console.WriteLine();

            ////Question 10:
            //Console.WriteLine("Question 10");
            //string word1  = "horse";
            //string word2 = "ros";
            //int minLen = MinDistance( word1,  word2);
            //Console.WriteLine("Minimum number of operations required are {0}", minLen);
            //Console.WriteLine();
        }
    

        /*
        
        Question 1:
        Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        Note: The algorithm should have run time complexity of O (log n).
        Hint: Use binary search
        Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2
        Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1
        Example 3:
        Input: nums = [1,3,5,6], target = 7
        Output: 4
        */

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                //Write your Code here.
                //initializing variables
                int a = 0;
                int b = nums.Length;
                int mid = 0;  // calculating middle3 position
                int check = 0; //if target found check gets 1 else checks for insert position
                while (a < b)
                {
                    if (target < nums[a]) //edge case when target less than least element
                    {
                        mid = 0;
                        break;
                    }
                    mid = (a + b) / 2;
                    if (nums[mid] == target)
                    {

                        check = 1;
                        break;
                    }
                    else if ((nums[mid] > target) && (b - a) != 1) //b-a == 1 means a and b traveresed entire array
                    {
                        b = mid;

                    }
                    else if ((nums[mid] < target) && (b - a) != 1)
                    {

                        a = mid;
                    }
                    else if (b - a == 1 && check == 0)//calculates insert position when a and b traversed
                    {
                        mid = b;
                        break;
                    }
                }
                     return mid;
                //self reflection: Edge cases should be kept in mind and also insert position code should be added to binary search

            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
         
        Question 2
       
        Given a string paragraph and a string array of the banned words banned, return the most frequent word that is not banned. It is guaranteed there is at least one word that is not banned, and that the answer is unique.
        The words in paragraph are case-insensitive and the answer should be returned in lowercase.

        Example 1:
        Input: paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.", banned = ["hit"]
        Output: "ball"
        Explanation: "hit" occurs 3 times, but it is a banned word. "ball" occurs twice (and no other word does), so it is the most frequent non-banned word in the paragraph. 
        Note that words in the paragraph are not case sensitive, that punctuation is ignored (even if adjacent to words, such as "ball,"), and that "hit" isn't the answer even though it occurs more because it is banned.

        Example 2:
        Input: paragraph = "a.", banned = []
        Output: "a"
        */

        public static string MostCommonWord(string paragraph, string[] banned)
        {
            try
            {
                int max = 0;
                string word = "";
                paragraph = paragraph.ToLower();//making paragraph to lower case
                string para_new = Regex.Replace(paragraph, "[/.,<>?';:!@]"," ");//removing all special characters
                string[] para_list = para_new.Split(" ");
                var word_dict = new Dictionary <string, int>();

                foreach (var name in para_list)
                {

                    if (!banned.Contains(name) && word_dict.ContainsKey(name))//if word is not in banned list then it goes into dictionary
                    {
                        word_dict[name]++;
                        if (max < word_dict[name])//checking for max count and its word
                        {
                            max = word_dict[name];
                            word = name;
                    
                        }
                    }
                    else
                    {
                        word_dict[name] = 1;

                        if (max < word_dict[name])//checking again to eliminate the edge case
                        {
                            max = word_dict[name];
                            word = name;

                        }

                    }
                
                //self reflection - creating dictionaries and checking for a word and max frequency
                }
                    
                return word;
            }
            catch (Exception)
            {

                throw; 
            }
        }

        /*
        Question 3:
        Given an array of integers arr, a lucky integer is an integer that has a frequency in the array equal to its value.
        Return the largest lucky integer in the array. If there is no lucky integer return -1.
 
        Example 1:
        Input: arr = [2,2,3,4]
        Output: 2
        Explanation: The only lucky number in the array is 2 because frequency[2] == 2.

        Example 2:
        Input: arr = [1,2,2,3,3,3]
        Output: 3
        Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.

        Example 3:
        Input: arr = [2,2,2,3,3]
        Output: -1
        Explanation: There are no lucky numbers in the array.
         */

        public static int FindLucky(int[] arr)
        {
            try
            {
                //write your code here

                var new_arr = new Dictionary<int, int>();//taking empty dictionary for key value pairs of numbers
                int max = -1; //initializing to -1 covers the edge cases when no element is matched
                foreach (var num in arr)//chcecking num in arr and adding to list the number of occurences
                {

                    if (new_arr.ContainsKey(num))
                    {
                        new_arr[num]++;
                    }
                    else
                    {
                        new_arr[num] = 1;

                    }
                }

                foreach (KeyValuePair<int,int> lnum in new_arr)//iterating in the dictionary for chceckin gthe lucky num
                {
                    if (lnum.Key == lnum.Value)
                    {
                        if (lnum.Value>max)//only max value should be retured 
                        {
                            max = lnum.Value;
                        }
                    }
                }


                return max;
                //self - reflection is creating dictionaries and finding occurances of words

            }
            catch (Exception)
            {

                throw;
            }

        }

        /*
        
        Question 4:
        You are playing the Bulls and Cows game with your friend.
        You write down a secret number and ask your friend to guess what the number is. When your friend makes a guess, you provide a hint with the following info:
        •	The number of "bulls", which are digits in the guess that are in the correct position.
        •	The number of "cows", which are digits in the guess that are in your secret number but are located in the wrong position. Specifically, the non-bull digits in the guess that could be rearranged such that they become bulls.
        Given the secret number secret and your friend's guess guess, return the hint for your friend's guess.
        The hint should be formatted as "xAyB", where x is the number of bulls and y is the number of cows. Note that both secret and guess may contain duplicate digits.
 
        Example 1:
        Input: secret = "1807", guess = "7810"
        Output: "1A3B"
        Explanation: Bulls relate to a '|' and cows are underlined:
        "1807"
          |
        "7810"

        */

        public static string GetHint(string secret, string guess)
        {
            try
            {
                //write your code here.
                int a = 0, b = 0;
                string res = "", new_s = "", new_g = "";
                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] == guess[i])//if element is matched we are removing that element and increasing the a
                    {
                        a++;
                        new_s = secret.Remove(i, 1);//removing element and creating new secret and guess
                        new_g = guess.Remove(i, 1);
                    }
                }

                for (int p = 0; p < new_s.Length; p++)
                {
                    if (new_g.Contains(new_s[p]))//if element is in new guess then its removed to ensure duplicates and remove edge case
                    {
                        b++;
                        int x = new_g.IndexOf(new_s[p]);
                        new_g = new_g.Remove(x, 1);
                    }
                }
                res = a + "A" + b + "B";
                return res;
                //edge case- new strings are created to ensure no element is checked repeatedly
                //self reflection - learnt elements iteration in strings and its concatination and new method (Contains) 
            }
            catch (Exception)
            {

                throw;
            }
        }


        /*
        Question 5:
        You are given a string s. We want to partition the string into as many parts as possible so that each letter appears in at most one part.
        Return a list of integers representing the size of these parts.

        Example 1:
        Input: s = "ababcbacadefegdehijhklij"
        Output: [9,7,8]
        Explanation:
        The partition is "ababcbaca", "defegde", "hijhklij".
        This is a partition so that each letter appears in at most one part.
        A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits s into less parts.

        */

        public static List<int> PartitionLabels(string s)
        {
            try
            {
                int start = 0, end = 0;
                int[] place = new int[1000];
                char[] input_list = s.ToCharArray();

                for (int i = 0; i < input_list.Length; i++)
                {
                    place[input_list[i]] = i;
                }
                List<int> out_list = new List<int>();

                while (start < input_list.Length)
                {
                    end = place[input_list[start]];
                    for (int i = start; i < end; i++)
                    {
                        end = Math.Max(end, place[input_list[i]]);
                    }
                    out_list.Add(end - start + 1);
                    start = end + 1;
                }
                return out_list;

            }
            catch (Exception)
            {
                throw;
            }
        }

        /*
        Question 6

        You are given a string s of lowercase English letters and an array widths denoting how many pixels wide each lowercase English letter is. Specifically, widths[0] is the width of 'a', widths[1] is the width of 'b', and so on.
        You are trying to write s across several lines, where each line is no longer than 100 pixels. Starting at the beginning of s, write as many letters on the first line such that the total width does not exceed 100 pixels. Then, from where you stopped in s, continue writing as many letters as you can on the second line. Continue this process until you have written all of s.
        Return an array result of length 2 where:
             •	result[0] is the total number of lines.
             •	result[1] is the width of the last line in pixels.
 
        Example 1:
        Input: widths = [10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], s = "abcdefghijklmnopqrstuvwxyz"
        Output: [3,60]
        Explanation: You can write s as follows:
                     abcdefghij  	 // 100 pixels wide
                     klmnopqrst  	 // 100 pixels wide
                     uvwxyz      	 // 60 pixels wide
                     There are a total of 3 lines, and the last line is 60 pixels wide.



         Example 2:
         Input: widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], 
         s = "bbbcccdddaaa"
         Output: [2,4]
         Explanation: You can write s as follows:
                      bbbcccdddaa  	  // 98 pixels wide
                      a           	 // 4 pixels wide
                      There are a total of 2 lines, and the last line is 4 pixels wide.

         */

        public static List<int> NumberOfLines(int[] widths,string s)
        {
            try
            {
                //write your code here.

                int line = 1;
                int len = 0;
                foreach (char x in s)// iterating through entire length
                {
                    int w_len = widths[Convert.ToInt32(x) - Convert.ToInt32('a')];//ascii value of (x - 65) as a is 65
                    len += w_len;//adding all width to len and when its greater than 100
                    if (len > 100)
                    {
                        line += 1;//increasing the line
                        len = w_len;//last w_len is assigned to len ie the first char in new line
                    }
                }
                return new List<int>() { line, len };
                //self reflection - edge cases such as when it gets nto new line the element's width in last line ending should be added 

            }
            catch (Exception)
            {
                throw;
            }

        }


        /*
        
        Question 7:

        Given a string bulls_string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
        An input string is valid if:
            1.	Open brackets must be closed by the same type of brackets.
            2.	Open brackets must be closed in the correct order.
 
        Example 1:
        Input: bulls_string = "()"
        Output: true

        Example 2:
        Input: bulls_string  = "()[]{}"
        Output: true

        Example 3:
        Input: bulls_string  = "(]"
        Output: false

        */

        public static bool IsValid(string bulls_string10)
        {
            try
            {
                //write your code here.

                int str_length = bulls_string10.Length;
                if (str_length % 2 != 0)//clearing edge cases and others simply when length is not even it means improper closing of brackets
                {
                    return false;
                }
                List<char> ele_list = new List<char> { };
                char[] end_list = new char[] { ')', '}', ']' };//list for ending brackets

                for (int i = 0; i < str_length; i++)
                {
                    if (bulls_string10[i] == '(') { ele_list.Insert(0, ')'); }//inserting the respective elements closing bracket in list at first position
                    else if (bulls_string10[i] == '{') { ele_list.Insert(0, '}'); }
                    else if (bulls_string10[i] == '[') { ele_list.Insert(0, ']'); }
                    else if (end_list.Contains(bulls_string10[i]) && ele_list.Count > 0 && bulls_string10[i] == ele_list[0])
                        //if its a closing bracket and its in the first position of list and to remove edge case checking if atleast one elemenet is in ele_list 
                    {
                        ele_list.RemoveAt(0);//removing the closing bracket as this is in proper sequence
                    }
                    else { return false; }//says that sequence is not correct so immedffiately returns false
                }
                return ele_list.Count == 0;//after proper removing of all closing brackets in ele list final counts is 0
                //self-reflection -> very good implementation of stack and keeping the sequence and checking all edge cases
                //Most important is following the sequence

            }
            catch (Exception)
            {
                throw;
            }


        }



        /*
         Question 8
        International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:
        •	'a' maps to ".-",
        •	'b' maps to "-...",
        •	'c' maps to "-.-.", and so on.

        For convenience, the full table for the 26 letters of the English alphabet is given below:
        [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
        Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.
            •	For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
        Return the number of different transformations among all words we have.
 
        Example 1:
        Input: words = ["gin","zen","gig","msg"]
        Output: 2
        Explanation: The transformation of each word is:
        "gin" -> "--...-."
        "zen" -> "--...-."
        "gig" -> "--...--."
        "msg" -> "--...--."
        There are 2 different transformations: "--...-." and "--...--.".

        */

        public static int UniqueMorseRepresentations(string[] words)
        {
            try
            {
                //write your code here.

                int a = 97;//ascii of small a
                var mor_dict = new Dictionary<string, string>();
                //creating morse code list
                string[] mor_list = new string[26] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
                foreach (string i in mor_list)
                {
                    string ch = Convert.ToString(Convert.ToChar(a));//assigning key as a using ascii of small a = 97
                    mor_dict[ch] = i;//key as small letters and value as morse code
                    //Console.WriteLine(ch);
                    a++;
                }
                string code = "";
                int count = 0;
                var given_list = new List<string>();
                foreach (string ele in words)
                {
                    //Console.WriteLine(i.Length);
                    for (int j = 0; j < ele.Length; j++)
                    {
                        code += mor_dict[Convert.ToString(ele[j])];//code is updated for a particular word
                    }
                    if (!given_list.Contains(code))//checking if the code is unique only then it will add in list
                    {
                        given_list.Add(code);
                        count++; // all unique elements are counted
                    }
                    code = "";//again making code to null so that new word starts fresh in next iteration
                }

                return count;
                //self reflection - assigning key value pairs and creating dictionaries.
                ////Also adding counter for unique elements and making code to null after each iteration
            }
            catch (Exception)
            {
                throw;
            }

        }

      


        /*
        
        Question 9:
        You are given an n x n integer matrix grid where each value grid[i][j] represents the elevation at that point (i, j).
        The rain starts to fall. At time t, the depth of the water everywhere is t. You can swim from a square to another 4-directionally adjacent square if and only if the elevation of both squares individually are at most t. You can swim infinite distances in zero time. Of course, you must stay within the boundaries of the grid during your swim.
        Return the least time until you can reach the bottom right square (n - 1, n - 1) if you start at the top left square (0, 0).

        Example 1:
        Input: grid = [[0,1,2,3,4],[24,23,22,21,5],[12,13,14,15,16],[11,17,18,19,20],[10,9,8,7,6]]
        Output: 16
        Explanation: The final route is shown.
        We need to wait until time 16 so that (0, 0) and (4, 4) are connected.

        */

        public static int SwimInWater(int[,] grid)
        {
            try
            {
                //write your code here.
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*
         
        Question 10:
        Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
        You have the following three operations permitted on a word:

        •	Insert a character
        •	Delete a character
        •	Replace a character
         Note: Try to come up with a solution that has polynomial runtime, then try to optimize it to quadratic runtime.

        Example 1:
        Input: word1 = "horse", word2 = "ros"
        Output: 3
        Explanation: 
        horse -> rorse (replace 'h' with 'r')
        rorse -> rose (remove 'r')
        rose -> ros (remove 'e')

        */

        public static int MinDistance(string word1, string word2)
        {
            try
            {
                //write your code here.
                return 0;

            }
            catch (Exception)
            {

                throw;
            }
            static int minDistanceSol(String word1, String word2, int size1, int size2)
            {
                // Return the size of the second string if the first string is empty
                if (size1 == 0)
                    return size2;

                // Return the size of the first string if the second string is empty
                if (size2 == 0)
                    return size1;

                // If last characters of two strings are same, consider the rest of the strings.
                if (word1[size1 - 1] == word2[size2 - 1])
                    return minDistanceSol(word1, word2, size1 - 1, size2 - 1);

                // If last characters are not same, perform recursion for insert, replace and remove.

                return min(minDistanceSol(word1, word2, size1, size2 - 1), minDistanceSol(word1, word2, size1 - 1, size2), minDistanceSol(word1, word2, size1 - 1, size2 - 1)) + 1;
            }

            static int min(int a, int b, int c)
            {
                //Finding the minimum of the three operations performed in the minDistanceSol method
                if (a <= b && a <= c)
                    return a;
                if (b <= a && b <= c)
                    return b;
                else
                    return c;
            }

            public static int MinDistance(string word1, string word2)
            {
                try
                {
                    //write your code here.
                    int distance = minDistanceSol(word1, word2, word1.Length, word2.Length);

                    return distance;

                }
                catch (Exception)
                {

                    throw;
                }




            }





        }
    }
}
