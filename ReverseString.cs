using System;
namespace CS_Practice
{
    /*
     * REVERSE A STRING    
     * Write a Solution which reverse the string word by word. 
     * Keep Upper case at the beginning.   
     * INPUT:   "Kasia" 
     * RESULT:  "Aisak"
     * INPUT:   "Bielsko-Biala" 
     * RESULT:  "Alaib-Oksleib"
     * INPUT:   "Hello World!" 
     * RESULT:  "!Dlrow Olleh"
     */
    public class ReverseString
    {
        static public string reverseString(string input)
        {
            string output = "";
            input = input.ToLower();
            char[] arr = input.ToCharArray();

            for (int i = 0; i < input.Length; i++)
                output += input[input.Length - 1 - i]; //reverse

            return capitalizeFirstOfWord(output); //upper
        }

        static private string capitalizeFirstOfWord(string input)
        {
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsLetter(arr[i]) && (i == 0 || !Char.IsLetter(arr[i - 1]) ))
                    arr[i] = Char.ToUpper(arr[i]);
            }

            string output = new string(arr);
            return output;
        }
    }
}
/* C++ implementation I wrote as first so I can translate it to C# as I'm more familiar with C++

#include <iostream>
#include <cctype> //using for isalpha
using namespace std; //cause writing std:: is too hard

char toLower(char i);
char toUpper(char i);
string lower(string i);
string capitalizeFirstOfWord(string i);
string reverseString(string i);
string reverseStringExceptA(string i);

int main() {
    
    cout<<reverseString("Kasia")<<endl; //Aisak
    cout<<reverseString("Bielsko-Biala")<<endl; //Alaib-Oksleib
    cout<<reverseString("Hello World!")<<endl; //!Dlrow Olleh
    
    //cout<<"Expected: kaerM Result: "<<reverseStringExceptA("Marek")<<endl;
    //cout<<"Expected: inoMa Result: "<<reverseStringExceptA("Monia")<<endl;
    //atempted RevertStringExceptA and failed miserably ;/
      
cout<<endl; return 0;
}


 * REVERSE A STRING
 * Write a Solution which reverse the string word by word.
 * Keep Upper case at the beginning.
 * INPUT:   "Kasia"
 * RESULT:  "Aisak"
 * INPUT:   "Bielsko-Biala"
 * RESULT:  "Alaib-Oksleib"
 * INPUT:   "Hello World!"
 * RESULT:  "!Dlrow Olleh"

char toLower(char i)
{
    if (i >= 65 && i <= 90)//isUpper
        return i + 32;
    else
        return i;
}
char toUpper(char i)
{
    if (i >= 97 && i <= 122)//isLower
        return i - 32;
    else
        return i;
}
string lower(string input)
{
    for (int i = 0; i < input.length(); i++)
        input[i] = toLower(input[i]);
    return input;
}
string capitalizeFirstOfWord(string input)
{
    for (int i = 0; i < input.length(); i++)
    {
        //((input[i] >= 65 && input[i] <= 90)||(input[i] >= 97 && input[i] <= 122) isalpha xd
        if (isalpha(input[i]) && (i == 0 || !isalpha(input[i - 1])))
            input[i] = toUpper(input[i]);
    }
    return input;
}
string reverseString(string input)
{
    string output = "";
    input = lower(input); //lower
    for (int i = 0; i < input.length(); i++)
        output += input[input.length() - 1 - i]; //reverse

    return capitalizeFirstOfWord(output); //upper
}
*/