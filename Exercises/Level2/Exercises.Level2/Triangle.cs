using System;

namespace Exercises.Level2;
public class Triangle
{
    /// <summary>
    /// Note: compleete half trangle first
    /// 
    /// The program:
    ///  You must create a triangle. 
    ///  n is the number of lines a triangle will have.
    ///  Triangle body has to be made out of "*",
    ///  so result should for 3 be like:
    ///  * 
    /// ***
    ///*****
    /// 
    /// Example of 5:
    /// 
    ///    *        = 4 spaces, 5 symbols
    ///   ***       = 3 spaces, 6 symbols
    ///  *****      = 2 spaces, 7 symbols
    /// *******     = 1 space,  8 symbols
    ///*********    = no spaces, 9 symbols
    ///
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] GetTRiangle(int n)
    {
        //return single star, if n = 1
        if (n == 1)
            return new string[] { "*" };
        //otherwise, create a new array and fill with stars
        string[] triangle = new string[n];
        int spaces = n - 1, stars = 1;
        //first loop = amount of lines
        for (int i = 0; i < n; i++)
        {
            //1st nested loop - fill the line with spaces
            for (int j = 0; j < spaces; j++)
                triangle[i] += " ";
            //2nd nested loop = fill with stars
            for (int k = 0; k < stars; k++)
                triangle[i] += "*";
            spaces--;
            stars += 2;
        }
        return triangle;

    }
}
