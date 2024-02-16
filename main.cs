public class Solution {
    public int Candy(int[] ratings) 
    {
        // [3,1,4,2,0,2]
        int[] amount = new int[ratings.Length];
        Array.Fill(amount,1);
        int count = ratings.Length;
        for(int i = 1; i < ratings.Length; i++)
        {
            if(ratings[i] > ratings[i-1])
                amount[i] = amount[i-1] + 1;
        }
        for(int i = ratings.Length -2; i >= 0; i--)
        {
            if(ratings[i] > ratings[i+1])
                amount[i] = (amount[i] > amount[i+1] + 1 ? amount[i] : amount[i+1] + 1);
        }
        return amount.Sum();
    }
}
