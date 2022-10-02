using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    string stringSent = "abcdfgerj";
    string stringRec ="abcdfger";
    string missing = "";
    foreach(char i in stringSent){
        
        if(stringRec.IndexOf(i) == -1){
            missing += i;
        }
        
    }
    Console.WriteLine(missing);
    }
}
