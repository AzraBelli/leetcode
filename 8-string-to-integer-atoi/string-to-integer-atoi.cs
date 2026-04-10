public class Solution {
    public int MyAtoi(string s) {
        string newR="";
        s=s.Trim();
        if (s.Length == 0)
            return 0;
        int i=0;
        bool neg=false;
        if(s[0]=='-' || s[0]=='+')
            {
                neg = s[i] == '-';
                i++;
            }
        long result = 0;
        for(;i<s.Length;i++)
        {   result = result * 10 + (s[i] - '0');
            if(char.IsDigit(s[i])  )
            {
                newR+=s[i];  
                           
            }
            else{
                break;
            }  
            if (!neg && result > int.MaxValue)
                return int.MaxValue;

            if (neg && -result < int.MinValue)
                return int.MinValue;

        }
        if (newR == "" || newR == "-" || newR == "+")
            return 0;
        else
           {
            int rVal= neg ? int.Parse('-'+newR) : int.Parse(newR);
            return rVal;
           }
    }
}