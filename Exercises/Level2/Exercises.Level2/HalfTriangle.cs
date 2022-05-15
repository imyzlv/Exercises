using System;

namespace Exercises.Level2;
public class HalfTriangle
{
    /// <summary>
    /// The program:
    ///  You must create a half triangle. 
    ///  n is the number of lines a triangle will have.
    ///  Triangle body has to be made out of "*",
    ///  so result should for 3 be like:
    ///* 
    ///***
    ///*****
    /// 
    /// Example of 5:
    /// 
    ///* =          1 
    ///*** =        3 
    ///***** =      5
    ///******* =    7
    ///********* =  9
    ///
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public string[] GetHalfTriangle(int n)
    {
        int lineLength = 1;
        string[] halfTriangle = new string[n];
        //return a single star, if n = 1
        if (n == 1)
            halfTriangle[0] = "*";
        else
        {
            for (int i = 0; i < n; i++)
            {
                if (i == 1)
                    halfTriangle[0] = "*";
                for (int j = 0; j < lineLength; j++)
                    halfTriangle[i] += "*";
                lineLength += 2;
            }
        }
        return halfTriangle;
    }
}
