using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace HangmanLib
{
    [Serializable]
    public class Data
    {
        #region Files Path
        private static readonly string topicFilePath = Path.Combine(Environment.CurrentDirectory, "topics.bin");
        private static readonly string wordFilePath = Path.Combine(Environment.CurrentDirectory, "words.bin");
        #endregion

        private List<Topic> topicsList;
        private List<Word> wordsList;
        private static Data Instance; //single-ton: all object created shared the same instance

        private Data()
        {
            topicsList = new List<Topic>();
            wordsList = new List<Word>();
        }

        public static Data GetData
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Data();
                }
                return Instance;
            }
        }

        public List<Topic> GetTopics()
        {
            return topicsList;
        }

        public Topic GetTopicAt(int index)
        {
            return topicsList[index];
        }

        public List<Word> GetWords()
        {
            return wordsList;
        }

        public Word GetWord(string wName)
        {
            return wordsList[GetWordIndexOf(wName)];
        }

        public Word GetWordAt(int index)
        {
            return wordsList[index];
        }

        public void AddTopic(int tIndex, string tName)
        {
            topicsList.Add(new Topic(tIndex, tName));
        }

        public void AddWord(int tIndex, string wName, string hName = "")
        {
            wordsList.Add(new Word(tIndex, wName, hName));
        }

        public void AddHint(int tIndex, string wName, string hName)
        {
            foreach (Word w in wordsList)
            {
                if (w.TopicIndex == tIndex && w.WordName == wName)
                {
                    w.WordsHint = hName;
                    break;
                }
            }
        }

        public void RemoveTopic(Topic topic)
        {
            topicsList.Remove(topic);
        }

        public void RemoveTopicAt(int tIndex)
        {
            topicsList.RemoveAt(tIndex);
            RemoveAllWordRelatedToTopic(tIndex);
        }

        public void RemoveWord(string wName)
        {
            wordsList.RemoveAt(GetWordIndexOf(wName));
        }

        public void RemoveWordAt(int wIndex)
        {
            wordsList.RemoveAt(wIndex);
        }

        public void RemoveHint(int tIndex, string wName)
        {
            foreach (Word w in wordsList)
            {
                if (w.TopicIndex == tIndex && w.WordName == wName)
                {
                    w.WordsHint = "";
                    break;
                }
            }
        }

        private int GetWordIndexOf(string wName)
        {
            int wIndex = -1;
            foreach (Word w in wordsList)
            {
                if (w.WordName == wName)
                {
                    wIndex = wordsList.IndexOf(w);
                    break;
                }
            }
            return wIndex;
        }

        private void RemoveAllWordRelatedToTopic(int tIndex)
        {
            for (int i = 0; i < wordsList.Count; i++)
            {
                if (wordsList[i].TopicIndex == tIndex)
                {
                    wordsList.RemoveAt(i);
                }
            }
        }

        #region File Management
        public void Save()
        {
            IFormatter bfs = new BinaryFormatter();

            // save topicsList to topics.bin
            if (File.Exists(topicFilePath))
            {
                File.Delete(topicFilePath);
            }
            using (FileStream fs = new FileStream(topicFilePath, FileMode.Create))
            {
                bfs.Serialize(fs, topicsList);
            }

            // save wordsList to words.bin
            if (File.Exists(wordFilePath))
            {
                File.Delete(wordFilePath);
            }
            using (FileStream fs = new FileStream(wordFilePath, FileMode.Create))
            {
                bfs.Serialize(fs, wordsList);
            }
        }

        public void Load()
        {
            IFormatter bfs = new BinaryFormatter();

            if (File.Exists(topicFilePath))
            {
                // load topics from topics.bin into topicsList
                using (FileStream fs = new FileStream(topicFilePath, FileMode.Open))
                {
                    topicsList = (List<Topic>)bfs.Deserialize(fs);
                }
            }

            if (File.Exists(wordFilePath))
            {
                // load words from words.bin into wordsList
                using (FileStream fs = new FileStream(wordFilePath, FileMode.Open))
                {
                    wordsList = (List<Word>)bfs.Deserialize(fs);
                }
            }
        }
        #endregion

        #region Tools
        internal Word GetRandomWord()
        {
            Random rand = new Random();

            if (wordsList.Count > 0)
            {
                return wordsList[rand.Next(0, wordsList.Count)];
            }
            else
            {
                return null;
            }
        }

        internal Topic GetRandomTopic()
        {
            Random rand = new Random();
            List<Topic> topicsHasWord = new List<Topic>();
            for (int i = 0; i < topicsList.Count; i++)
            {
                if (WordExistInTopic(i))
                {
                    topicsHasWord.Add(topicsList[i]);
                }
            }

            return topicsList[rand.Next(0, topicsHasWord.Count)];
        }

        public bool WordExistInAnyTopic()
        {
            if (wordsList.Count > 0)
            {
                return true;
            }
            return false;
        }

        internal bool WordExistInTopic(int tIndex)
        {
            if (wordsList.Any(x => x.TopicIndex == tIndex))
            {
                return true;
            }
            return false;
        }

        internal bool WordExist(string wName)
        {
            if (wordsList.Any(x => x.WordName == wName))
            {
                return true;
            }
            return false;
        }
        #endregion
    }

}