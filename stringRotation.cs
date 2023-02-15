public class StringRotation
{
    public static string stringRotation(string s, int n)
    {
        /*
        input: "MyString", 2
        output: "ngMyStri"
        */
        if (n <= 0 || n > s.Length)
        {
            return "Error";
        }
        int subStart = s.Length - n;
        string move = s.Substring(subStart);
        StringBuilder result = new StringBuilder();
        result.Append(move +s.Substring(0,subStart));
        return result.ToString();
    }
}
