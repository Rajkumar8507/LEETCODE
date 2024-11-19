public class Solution {
    public int Reverse(int x) {
        int s = 0,t;
        while(x!=0){
             t = x%10;
              if (s > (int.MaxValue / 10) || (s == int.MaxValue / 10 && t > 7)) {
                return 0; 
            }
            if (s < (int.MinValue / 10) || (s == int.MinValue / 10 && t < -8)) {
                return 0; 
            }
            s = t + s*10 ; 
            x = x/10;
        }

        return s;
    }
}