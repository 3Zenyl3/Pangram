public static class Pangram
{
    public static string check = "qwertyuiopasdfghjklzxcvbnm";
    public static bool IsPangram(string input)
    {
            string res = "";
            int cnt = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (check.Contains(input[i].ToString().ToLower()))
            {
                if (!res.Contains(input[i].ToString().ToLower()))
                {
                    cnt++;
                    res += input[i].ToString().ToLower();
                }
                if (cnt == 26)
                    return true;
            }
            

        }
        return false;
    }
}
