using System.Collections.Generic;

namespace ProtoType
{
    public interface IVocabularyStore
    {
        int getWordCount();

        string getUnLearnedWords();

        void setWordLearned(string word);

        void setWordUnLearned(string word);

        List<string> getWOrdList();

        string getMeaning(string word);

        IVocabularyStore getCopy();
    }
}
