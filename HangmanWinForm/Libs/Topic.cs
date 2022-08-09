using System;

namespace HangmanLib
{
    [Serializable]
    public class Topic
    {
        private int topicIndex;
        private string topicName;

        public int TopicIndex { get { return topicIndex; } }
        public string TopicName { get { return topicName; } }

        public Topic(int tIndex, string tName)
        {
            topicIndex = tIndex;
            topicName = tName;
        }
    }
}