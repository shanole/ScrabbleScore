using System.Collections.Generic;
using System;
using System.Linq;

namespace ScrabbleScore.Models
{
  public class Word
  {
    public string PlayedWord { get; set; }
    private static char[] _scoreOne = {'A','E','I','O','U','L','N','R','S','T'};
    private static Dictionary<char[],int> _wordScores = new Dictionary<char[],int>() { {_scoreOne,1} };
    public Word(string playedWord)
    {
      PlayedWord = playedWord;
    }
    public int GetScore()
    {
      char[] wordArray = PlayedWord.ToCharArray();
      foreach(char element in wordArray)
      {
        if (_scoreOne.Contains(element))
        {
          return _wordScores[_scoreOne];
        }
      }
      return 0;
    }
  }
}