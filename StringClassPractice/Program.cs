


using StringClassPractice;

class Program
{
    static void Main()
    {
        //Twine stuff. Abandoned for now.
        char[] characters = [ 'R','a','c','e','c','a','r'];

        Twine twine = new Twine(characters);

        twine.Print();
        int length = twine.Length();
        
        Console.WriteLine(length);
        bool isPalindrome = twine.IsPalindrome();
        Console.WriteLine(isPalindrome);
        twine.Reverse();
        twine.Trim(0, 3);

        twine.Print();
        twine.ToLowerCase();
        twine.ToUpperCase();


        //Cord stuff.

    }
}