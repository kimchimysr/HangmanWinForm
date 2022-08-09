using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Hangman WinForm V0.2
// Hours Spent: ~24H
// Codes = ~1200 Lines

namespace HangmanLib
{
    public class Hangman
    {
        private Data file;
        private static Hangman Instance;

        #region Game Variables
        private bool gameOver;
        private Word chosenWord;
        private string tempChosenWord;
        private string guessedLetters;
        private int mistakeCount;
        #endregion

        private Random rand;

        public Data File { get { return file; } }
        public Word ChosenWord { get { return chosenWord; } }
        public bool GameOver { get { return gameOver; } }
        public int MistakeCount { get { return mistakeCount; } }

        private Hangman()
        {
            InitializeFieldsValue();
        }

        // single-ton: all object created will share the same instance
        // to avoid having multiple instance
        public static Hangman GetHangman
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Hangman();
                }
                return Instance;
            }
        }

        private void InitializeFieldsValue()
        {
            file = Data.GetData;
            file.Load();
            gameOver = false;
            chosenWord = file.GetRandomWord();
            if (chosenWord != null)
            {
                tempChosenWord = chosenWord.WordName;
            }
            guessedLetters = string.Empty;
            mistakeCount = 0;
            rand = new Random();
        }

        public void StartNewGame()
        {
            gameOver = false;
            chosenWord = file.GetRandomWord();
            if (chosenWord != null)
            {
                tempChosenWord = chosenWord.WordName;
            }
            guessedLetters = string.Empty;
            mistakeCount = 0;
        }

        #region Game Logic
        public bool GuessLetterInChosenWord(string letterGuessed, out int letterIndex)
        {
            letterIndex = -1;
            if (tempChosenWord.Any(x => x.Equals(char.Parse(letterGuessed))))
            {
                // out correcly guessed letter index in string tempChosenWord
                letterIndex = GetIndexOfLetterInChosenWord(letterGuessed);

                // convert tempChosenWord into temp char[] as you cant modify character in a string
                char[] tempChosenWordCharArray = tempChosenWord.ToCharArray();

                // change the index of guessed letter into # to avoid finding the same letter in the same index
                // e.g. tempChosenWOrd = tall;
                // Before:
                // 1. player guess letter l, GuessLetterInChosenWord return letterIndex = 2;
                // tempChosenWord = tall; (no changes to tempChosenWord)
                // 2. player guess letter l, GuessLetterInChosenWOrd will return letterIndex = 2; again
                // - fix: assigning # into index of correctly guessed letter
                // After fix:
                // 1. player guess letter l, GuessLetterInChosenWord return letterIndex = 2;
                // tempChosenWord = ta#l; (changes to tempChosenWord)
                // 2. player guess letter l, GuessLetterInChosenWOrd will return letterIndex = 3; instead
                tempChosenWordCharArray[tempChosenWord.IndexOf(letterGuessed)] = '#';

                // make tempChosenWord equal to new string of char[]
                tempChosenWord = new string(tempChosenWordCharArray);

                // add correctly guessed letter into guessedLetters(Unsorted) to compare with chosenWord
                // e.g. chosenWord = tall;
                // 1. player guess letter a, which is the correct letter
                // guessedLetter = a;
                // 2. player guess letter t, which is the correct letter
                // guessedLetter = at;
                // 3. and so on
                // guessedLetter = atll;
                guessedLetters += letterGuessed;

                return true;
            }
            else
            {
                mistakeCount++;
            }
            return false;
        }

        public (int index, string letter) GetUnguessedLetterFromChosenWord()
        {
            // generate random index until find an index with character beside #
            int lIndex = -1;
            bool unguessedLetterIndex = false;
            do
            {
                lIndex = rand.Next(tempChosenWord.Length);
                if (tempChosenWord[lIndex] != '#')
                {
                    unguessedLetterIndex = true;
                }
            }
            while (!unguessedLetterIndex);

            // add the correct letter to guessedLetters
            guessedLetters += tempChosenWord[lIndex];

            // use stringBuilder to modify character from tempChosenWord
            // and replace tempChosenWord with the modified string
            StringBuilder tempStr = new StringBuilder(tempChosenWord);
            tempStr[lIndex] = '#';
            tempChosenWord = tempStr.ToString();

            mistakeCount++;

            return (lIndex, chosenWord.WordName[lIndex].ToString());
        }

        public void CheckConditionsOfGameOver()
        {
            // compare length instead of string because guessedLetter must have all the same letter
            // as chosenWord at this point even if guessedLetter is unsorted
            // e.g. guessedLetter = latl; and chosenWord = tall;
            // will count as correct
            if (mistakeCount >= 6 || guessedLetters.Length.Equals(chosenWord.WordName.Length))
            {
                gameOver = true;
            }
        }

        public string GetScrambledLetterOfChosenWord()
        {
            // scrambled the word and add 6 extra letters
            // e.g. word: tall => scrambled: latuodlcob

            // use SortedList for automatically sorted by key value = scrambled
            SortedList<int, char> tempList = new SortedList<int, char>();

            // add letters with random key value of chosenWord into tempList
            foreach (char ch in chosenWord.WordName)
            {
                tempList.Add(rand.Next(), ch);
            }

            // add 6 extra letter with random key into templist
            for (int i = 0; i < 7; i++)
            {
                tempList.Add(rand.Next(), (char)rand.Next('A', 'Z'));
            }

            // use StringBuilder for less computing time (1/3 of string)
            StringBuilder str = new StringBuilder();

            foreach (KeyValuePair<int, char> ch in tempList)
            {
                str.Append(ch.Value.ToString());
            }

            return str.ToString();
        }

        private int GetIndexOfLetterInChosenWord(string letterGuessed)
        {
            return tempChosenWord.IndexOf(letterGuessed);
        }
        #endregion
    }

}