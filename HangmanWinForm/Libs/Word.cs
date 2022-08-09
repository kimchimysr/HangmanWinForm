using System;

namespace HangmanLib
{
    [Serializable]
    public class Word
    {
        private readonly int topicIndex;
        private readonly string wordName;
        private string wordHint;

        public int TopicIndex { get { return topicIndex; } }
        public string WordName { get { return wordName; } }
        public string WordsHint { get { return wordHint; } set { wordHint = value; } }

        public Word(int tIndex, string wName, string wHint = "")
        {
            topicIndex = tIndex;
            wordName = wName;
            wordHint = wHint;
        }
    }

}