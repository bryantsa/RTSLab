public class AboveBelow
{
    /*
    input: [1, 5, 2, 1, 10], 6
    output: { "above": 1, "below": 4 }
    */
    public static Dictionary<string,int> aboveBelow(List<int> nums, int target)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("above",0);
        dict.Add("below",0);
        foreach(int num in nums)
        {
            if (num < target)
            {
                dict["below"]++;
            }
            else
            {
                dict["above"]++;
            }
        }
        return dict;
    }
}
