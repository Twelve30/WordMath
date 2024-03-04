using System;
class WordMath
    {
    public static void Main()
        {
        Console.WriteLine("This progam enumerates the numerical value of entered string and its length");
        Console.WriteLine("Enter command /br to exit");
        Console.WriteLine("This program ignores the numbers & symbols included in the string & case of input");
        try
            {
            for (; ; )
                {

                Console.Write("Enter the string : ");
                string str = Console.ReadLine(), y = "/br";
                if (string.Compare(str, y, true) == 0) { break; }
                else
                    {
                    string newstr = str.Trim(), temp = "";
                    char ch;
                    for (int i = 0; i < newstr.Length; i++)
                        {
                        if (char.IsLetter(newstr, i))
                            {
                            ch = char.ToLower(newstr[i]);
                            temp += ch;
                            }
                        else
                            {
                            continue;
                            }
                        }
                    decimal x = -(97 - 1) * temp.Length;
                    for (int j = 0; j < temp.Length; j++)
                        {
                        x += (int)temp[j];
                        }
                    Console.WriteLine("The length of inputted string is " + str.Length);
                    Console.WriteLine("The wordmath value of inputted string is " + x);
                    }                
                }
            }
        catch { Console.WriteLine("Sorry some error occurred"); }
        }
    }