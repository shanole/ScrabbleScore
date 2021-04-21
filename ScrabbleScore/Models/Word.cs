using System.Collections.Generic;

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
      return 0;
    }
  }
}