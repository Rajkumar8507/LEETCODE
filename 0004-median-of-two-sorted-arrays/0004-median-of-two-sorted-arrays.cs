public class Solution {
    public double FindMedianSortedArrays(int[] num1, int[] num2)
    {
       
 int[] num3=new int[num1.Length+num2.Length];
 int count = 0;
 for(int i = 0; i < num1.Length; i++)
 {
     num3[count++]=num1[i];
 }
         
 for (int i = 0; i < num2.Length; i++)
 {
     num3[count++] =num2[i];
 }


 for(int i = 0;i <count;i++)
 {
     Console.WriteLine(num3[i]);
 }
 Array.Sort(num3);
 if(num3.Length % 2 != 0)
 {
     int a = num3.Length / 2;
     return num3[a];
 }
 else
 {
     int a=num3.Length / 2;
     int b = num3[a] + num3[a - 1];
     return b/2.00;
 }  
    }
}