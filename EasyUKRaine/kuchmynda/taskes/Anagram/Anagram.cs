﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace WebApplication1.Taskes.Anagram
{
    class AnagramTask : ITask
    {
        public string Header { get; set; }
        public string Sence { get; set; }
        public LevelUA Level { get; set; } = LevelUA.Beginner;
        public int PointsOfTask { get; set; } = 100;
        public object Content { get; set; }

        public char?[] AnagramWord { get; set; } = null;

        public object CorrectAnswer { get; set; } = String.Empty;

        public void CreateAnagram()
        {
            var word=((string)CorrectAnswer);
            AnagramWord = new char?[word.Length];
            var forbiddenIndexes = new List<int>();
            int iter = 0;
            Random rand = new Random((int)DateTime.Now.Ticks);
            while (!AnagramWord.All(x => x.HasValue))
            {
                int index = rand.Next(word.Length);
                if(!forbiddenIndexes.Contains(index))
                {          
                    AnagramWord[iter] = word[index];
                    iter++;
                    forbiddenIndexes.Add(index);
                }
            }
        }
    }

    class AnagramWord : AnagramTask
    {   
        public AnagramWord() : base()
        {
            Content = "";
            Header = "Guess combination of word";
            Sence = "It is necessary to practice memory and vocabulary.";
        }  
    }
    class AnagramImage : AnagramTask
    {
        public AnagramImage() : base()
        {
            Content = new Image();
            Header = "What`s it? Guess combination of word";
            Sence = "It is necessary to practice memory and vocabulary.";
        }
    }

    class AnagramNoTip : AnagramTask
    {
        public AnagramNoTip() : base()
        {
            Content = null;  
            Header = "Guess combination of word without tips";
            Sence = "It is necessary to practice memory and vocabulary.";
        }
    }
}