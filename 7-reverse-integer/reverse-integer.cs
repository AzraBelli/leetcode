public class Solution {
    public int Reverse(int x) {
        string xt = x.ToString();
        int y=0;
        char[] charArray = xt.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);


        if (x < 0)
        {
            reversedString = "-" + reversedString.TrimEnd('-');
        }


        if (int.TryParse(reversedString, out y))
        {
            return y;
        }
        else
        {
            return 0;
        }
            }
}