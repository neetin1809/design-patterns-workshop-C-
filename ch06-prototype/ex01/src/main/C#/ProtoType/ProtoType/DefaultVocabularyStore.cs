using System.Collections.Generic;
using System.Linq;

namespace ProtoType
{
    public class DefaultVocabularyStore : IVocabularyStore
    {
        public Dictionary<string, string> wordMap;

        public DefaultVocabularyStore()
        {
            this.wordMap = new Dictionary<string, string>();
            //expensive lot of words will load here
            this.wordMap.Add("feature", "n. Add on");
            this.wordMap.Add("night", "n. Slogging for the Whole night");
        }

        public DefaultVocabularyStore(Dictionary<string, string> wordMap)
        {
            this.wordMap = wordMap;
        }

        public IVocabularyStore getCopy()
        {
            Dictionary<string, string> newWordMap = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> item in wordMap)
            {
                newWordMap.Add(item.Key, item.Value);
            }
            return new DefaultVocabularyStore(newWordMap);
        }

        public string getUnLearnedWords()
        {
            //throw new NotImplementedException();
            return null;
        }

        public int getWordCount()
        {
            return wordMap.Count;
        }

        public List<string> getWOrdList()
        {
            return wordMap.Keys.ToList();
        }

        public void setWordLearned(string word)
        {
            //some logic to set word learned preferably flag;
        }

        public void setWordUnLearned(string word)
        {
            //some logic to set word unlearned preferably flag;
        }

        public string  getMeaning(string word)
        {
            return wordMap[word]; 
        }
    }
}
