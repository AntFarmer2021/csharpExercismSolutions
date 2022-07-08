using System;
public static class Bob
{
    public static string Response(string statement)
    {
        if(statement.Trim().Length == 0 || statement.Trim().Equals(""))
        {
            return "Fine. Be that way!";
        }
        int countIsLetter = 0;
        int countIsUpper = 0;
        for(int i = 0; i < statement.Length; i++ )
        { 
            if(char.IsUpper(statement[i]))
            {
                countIsUpper++;
            }
            if(char.IsLetter(statement[i]))
            {
                countIsLetter++;
            }
        }
        if (countIsUpper > 0 && countIsLetter > 0 && countIsUpper == countIsLetter)
        {
            return "Whoa, chill out!";
        }
        
        if(statement.Trim().EndsWith("?"))
        {
            return "Sure.";
        }
        return "Whatever.";
    }
}