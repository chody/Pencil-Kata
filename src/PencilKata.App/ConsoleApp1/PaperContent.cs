namespace ConsoleApp1;

public static class PaperContent
{
    public static string pageContent = "";
    public static int pencilLife = 10;
    
    public static string WriteOnPage(string textToWrite)
    {
        // manage pencil fatigue 
        fatiguePencil(textToWrite);
        pageContent = pageContent + textToWrite;
        return pageContent;
    }

    public static int fatiguePencil(string textWritten)
    {
       // loop over this string and fatigue the pencil 
       for(var i = 0; i < textWritten.Length; i++)
       {
           if (textWritten[i].ToString() == " " || textWritten[i].ToString() == "\n")
           {
               continue;
           }
           // do nothing if it is a space
           if (char.IsUpper(textWritten[i]))
           {
               pencilLife -= 2;
           }
           else
           {
               pencilLife -= 1;
           }
           
           // if I detect that pencil life is zero at any point than I should only return spaces
           
       }

       return pencilLife;
    }
    
    
    // when a pencil is created it is given a value to determine how long it can last
    
    // when it writes spaces nothing is lost
    
    // when it writes lower case letters the value goes down by one, when upper case letters the value goes down by two
}