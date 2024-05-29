using System.Runtime.CompilerServices;

public static class Cord
{
    static public string ToLower(string str) { return str.ToLower(); }

    static public string ToUpper(string str) { return str.ToUpper(); }
    
    static public string Reverse(string str)
    {
        string reverseOrder = "";
        for (int i = 0; i < str.Length; i++)
        {
            reverseOrder = str[i] + reverseOrder;
        }
        return reverseOrder;
    }

    static public bool IsPalindrome(string str)
    {
        string lowercased = ToLower(str);
        string reversed = Reverse(lowercased);
        if(lowercased == reversed) { return true; } else { return false; }
    }

    static public string Trim(string str, int trimFront, int trimBack)
    {
        if(str.Length <= trimFront + trimBack) { return ""; }
        if(trimFront < 0) { trimFront = 0; }
        if(trimBack < 0) { trimBack = 0; }

        str = Reverse(str);
        string frontRemainder = "";
        if(trimFront > 0)
        {
            for (int i = 0; i < (str.Length - trimFront); i++)
            {
                frontRemainder += str[i];
            }
        }
        else
        {
            frontRemainder = str;
        }

        frontRemainder = Reverse(frontRemainder);

        string backRemainder = "";
        if(trimBack > 0)
        {
            for (int i = 0; i < (frontRemainder.Length - trimBack); i++)
            {
                backRemainder += frontRemainder[i];
            }
        }
        else
        {
            backRemainder = frontRemainder;
        }

        return backRemainder;
    }

    static public char[] ConvertToCharArray(string str)
    {
        char[] result = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            result[i] = str[i];
        }
        return result;
    }

    static public string RemoveNumbers(string str)
    {
        string result = "";
        foreach (var character in str)
        {
            if (!char.IsAsciiDigit(character))
            {
                result += character;
            }
        }
        return result;
    }

    static public string RemoveLetters(string str)
    {
        string result = "";
        foreach (var character in str)
        {
            if (!char.IsAsciiLetter(character))
            {
                result += character;
            }
        }
        return result;
    }

    static public string RemoveCharacter(string str, char removeCharacter)
    {
        string result = "";
        foreach (var character in str)
        {
            if (!(character == removeCharacter))
            {
                result += character;
            }
        }
        return result;
    }

    static public int Length(string str)
    {
        int count = 0;
        foreach (var character in str)
        {
            count++;
        }
        return count;
    }
}