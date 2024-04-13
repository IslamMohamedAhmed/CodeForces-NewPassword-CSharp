using static System.Console;
using static System.Convert;
using static System.Math;


int n, k,counter = 0;
char a =(char) 97;
string str2 = "";

string str1 = ReadLine();
var arr = str1.Split(" ");
n = ToInt32(arr[0]);
k = ToInt32(arr[1]);

for(int i = 0; i < n; i++)
{
    str2 += a;
    a++;
    if (a > 97 + k - 1)
    {
        a =(char) 97;
    }

}

WriteLine(str2);