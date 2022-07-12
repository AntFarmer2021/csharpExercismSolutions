using System;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        string result = identifier.Replace(' ', '_');  
        
        int i = 0;
        foreach (char element in result)
        {
            if (char.IsControl(result[i]))
            {
                result = result.Replace(result[i].ToString(), "CTRL");
                
            }
            else
            {
            i++;
            }
        }
        
        i = 0;
        foreach (char element in result)
        {
            if (element == '-')
            {
                result = result.Replace(result[i+1], char.ToUpper(result[i+1]));
                result = result.Remove(i, 1);
            }
            
            i++;
        }
        
        string greekLetters = "αβΓγΔδεζηΘθΙικΛλμνΞξοΠπρΣσςτυΦφχΨψΩω";
        i = 0;
        foreach (char element in result)
        {
            if (greekLetters.Contains(element))
            {
                result = result.Remove(i, 1);
            }
            else if (!char.IsLetter(element) && element != '_')
            {
                result = result.Remove(i, 1);
            }
            else
            {
            i++;
            }
        }
        return result;
    }
}