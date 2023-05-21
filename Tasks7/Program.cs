using Microsoft.VisualBasic;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
        Task15();
        Task16();
        Task18();
        Task20();
        Task21();
        Task22();
        Task23();
        Task24();
        Console.ReadLine();
    }
    public static void Task1()
    {
        string str = "Welcome, hello";
        Console.WriteLine(str);
    }
    public static void Task2()
    {
        string str = "microsoft.com";
        Console.WriteLine(str.Length);
    }
    public static void Task3()
    {
        string str = "microsoft.com";
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i] + " ");
        }
    }
    public static void Task4()
    {
        string str1 = "microsoft.com";
        char[] c = str1.ToCharArray();
        Array.Reverse(c);
        for (int i = 0; i < c.Length; i++)
        {
            Console.Write(c[i]);
        }
    }
    public static void Task5()
    {
        string str = "This is microsoft.com";
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' && char.IsLetter(str[i + 1]) && (i > 0))
            {
                count++;
            }
        }
        count++;
        Console.WriteLine("Total words in string : " + count);
    }
    public static void Task6()
    {
        string str1 = "This is first string";
        string str2 = "This is first string";
        bool result1 = str1.Equals(str2);
        int result2 = str1.Length;
        int result3 = str2.Length;
        if (result1 && result2 == result3)
        {
            Console.WriteLine("The length of both strings are equal and also, both strings are equal");
        }
    }
    public static void Task7()
    {
        string str = "Welcome to microsoft.com.";
        int x = 0, y = 0, z = 0;
        char[] ch = str.ToCharArray();
        foreach (var item in ch)
        {
            if (char.IsLetter(item))
            {
                x++;
            }
            if (char.IsDigit(item))
            {
                y++;
            }
            if (!char.IsLetterOrDigit(item))
            {
                z++;
            }
        }
        Console.WriteLine("Number of Alphabets in the string is: " + x);
        Console.WriteLine("Number of Digits in the string is: " + y);
        Console.WriteLine("Number of Special characters in the string is: " + z);
    }
    public static void Task8()
    {
        string str1 = " This is a string to be copied.";
        string str2 = string.Join("", str1);

        Console.WriteLine("The First string is :  {0}", str1);
        Console.WriteLine("The Second string is :  {0}", str2);
        Console.WriteLine("Number of characters copied: " + str2.Length);
    }
    public static void Task9()
    {
        string str = "Welcome to microsoft.com";
        int vowels = 0, consonant = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'i' || str[i] == 'e' || str[i] == 'u' || str[i] == 'o' || str[i] == 'A' || str[i] == 'I' || str[i] == 'E' || str[i] == 'U' || str[i] == 'O')
            {
                vowels++;
            }
            else if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
            {
                consonant++;
            }
        }
        Console.WriteLine("The total number of vowel in the string is: " + vowels);
        Console.WriteLine("The total number of consonant in the string is: " + consonant);
    }
    public static void Task10()
    {
        string str = "Welcome to microsoft.com.";
        int[] chcount = new int[255];
        int maxcount = 0;
        char ch = ' ';
        for (int i = 0; i < str.Length; i++)
        {
            chcount[str[i]]++;
        }
        for (int i = 0; i < str.Length; i++)
        {
            if (chcount[str[i]] > maxcount)
            {
                maxcount = chcount[str[i]];
                ch = str[i];
            }
        }
        Console.WriteLine("The Highest frequency of character " + ch);
        Console.WriteLine("appears number of times: " + maxcount);
    }
    public static void Task11()
    {
        string str = "this is a string";
        char[] ch = str.ToCharArray();
        Array.Sort(ch);
        for (int i = 0; i < ch.Length; i++)
        {
            Console.Write(" " + ch[i]);
        }
    }
    public static void Task12()
    {
        string str1 = "This is a Test String";
        string str2 = str1.Substring(10, 4);
        if (str1.Contains(str2))
        {
            Console.WriteLine("The substring exists in the string");
        }
    }
    public static void Task13()
    {
        string str = "This is a Test String";
        char ch;

        for (int i = 0; i < str.Length; i++)
        {
            ch = str[i];
            if (char.IsLower(ch))
            {
                Console.Write(char.ToUpper(ch));
            }
            else if (char.IsUpper(ch))
            {
                Console.Write(char.ToLower(ch));
            }
        }
    }
    public static void Task14()
    {
        string name = "", pass = "";
        int count = 0;
        while ((name != "abcd" && pass != "1234") && count != 3)
        {
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your password: ");
            pass = Console.ReadLine();
            if (name != "abcd" && pass != "1234")
            {
                count++;
            }
            else
            {
                count = 1;
            }
        }
        if (count == 3)
        {
            Console.WriteLine("Card is blocked");
        }
        else
        {
            Console.WriteLine("Password entered successfully!");
        }
    }
    public static void Task15()
    {
        string str1 = "this is a string";
        string str2 = str1.Substring(5, 2);
        int index = str1.IndexOf(str2);
        if (index < 0)
        {
            Console.WriteLine("Substring is not found");
        }
        else
        {
            Console.WriteLine("Found 'is' in 'this is a string' at position: " + index);
        }
    }
    public static void Task16()
    {
        Console.Write("Enter a character: ");
        char[] ch = Console.ReadLine().ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            if (char.IsUpper(ch[i]))
            {
                Console.WriteLine("The character is uppercase.");
            }
            else
            {
                Console.WriteLine("The character is lowercase.");
            }
        }
    }
    public static void Task18()
    {
        Console.Write("Enter original string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter finds string: ");
        string str2 = Console.ReadLine();
        Console.Write("Enter insert string: ");
        string str3 = Console.ReadLine();

        int index = str1.IndexOf(str2);
        str3 = " " + str3.Trim() + " ";
        str1 = str1.Insert(index, str3);
        Console.WriteLine("Modifies string is: " + str1);

    }
    public static void Task20()
    {
        string strSource = "Python";
        char[] destination = { 'w', '3', 'r', 'e', 's', 'o', 'u', 'r', 'c', 'e', ' ', 'C',
                'S', 'h', 'a', 'r', 'p', ' ', 'T', 'u', 't', 'o', 'r', 'i', 'a', 'l' };
        Console.WriteLine(destination);
        strSource.CopyTo(0, destination, 11, strSource.Length);
        Console.WriteLine(destination);
    }
    public static void Task21()
    {
        string[] arr =
        {
         "Actions speak louder than words",
         "Hello!",
         "Python.",
         "PHP.",
         "random"
        };
        foreach (var item in arr)
        {
            bool b = item.EndsWith('.');
            Console.WriteLine($" {item} ends in a period: {b}");
        }
    }
    public static void Task22()
    {
        string str1 = "php";
        string str2 = "java";
        string str3 = "abcd";

        string result1 = new string(str1.ToCharArray().Reverse().ToArray()).ToUpper();
        Console.WriteLine(result1);
        string result2 = new string(str2.ToCharArray().Reverse().ToArray()).ToUpper();
        Console.WriteLine(result2);
        string result3 = new string(str3.ToCharArray().Reverse().ToArray()).ToUpper();
        Console.WriteLine(result3);
    }
    public static void Task23()
    {
        string str1 = "aaaaaabbbbccc";
        string result1 = string.Empty;
        for (int i = 0; i < str1.Length; i++)
        {
            if (!result1.Contains(str1[i]))
            {
                result1 += str1[i];
            }
        }
        Console.WriteLine(result1);
        string str2 = "Python";
        string result2 = string.Empty;
        for (int i = 0; i < str2.Length; i++)
        {
            if (!result2.Contains(str2[i]))
            {
                result2 += str2[i];
            }
        }
        Console.WriteLine(result2);
        string str3 = "Java";
        string result3 = string.Empty;
        for (int i = 0; i < str3.Length; i++)
        {
            if (!result3.Contains(str3[i]))
            {
                result3 += str3[i];
            }
        }
        Console.WriteLine(result3);
    }
    public static void Task24()
    {
        string str1 = "Python";
        int len1 = 1-str1.Length%2;
        Console.WriteLine(str1.Substring(str1.Length / 2 - len1, 1 + len1));
        string str2 = "PHP";
        int len2 = 1 - str2.Length % 2;
        Console.WriteLine(str2.Substring(str2.Length / 2 - len2, 1 + len2));
        string str3 = "C#";
        int len3 = 1 - str3.Length % 2;
        Console.WriteLine(str3.Substring(str3.Length / 2 - len3, 1 + len3));
    }
}
