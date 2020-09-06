namespace ProtoType
{
    public class VocabuloryStoreFactory
    {
        private static IVocabularyStore vocabuloryStore = new DefaultVocabularyStore();

        public static IVocabularyStore getVocabularyStore()
        {
            return vocabuloryStore.getCopy();
        }
    }
}
