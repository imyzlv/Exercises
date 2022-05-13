﻿using System;

namespace Exercises.Level2;
public class WordsInTriangle
{
    /// <summary>
    /// Given array of words draw them inside a smallest possible triangle, compleeting rules. 
    /// !. Every word has to be drawn in a new line.
    /// 2. No word can touch wall of the triangle, meaning there has to a " " between a wall and word.
    /// 
    /// For example word Home:
    /// 
    ///      *
    ///     * *
    ///    *   *
    ///   *     *
    ///  * home  *
    /// ***********
    /// 
    /// a beautiful home:
    /// 
    ///         *
    ///        * *
    ///       *   *
    ///      *     *
    ///     *       *
    ///    * a       *
    ///   * beautiful *
    ///  * home        *
    /// *****************
    /// 
    /// </summary>
    /// <param name="words">Words to put in triangle</param>
    /// <returns></returns>
    public string[] GetWordInTriangle(string[] words)
    {
        //string[] wordTriangle = new string[];
        string longestWord = "";
        foreach(string temp in words)
        {
            if (temp.Length > longestWord.Length)
                longestWord = temp;
        }

    }
}
