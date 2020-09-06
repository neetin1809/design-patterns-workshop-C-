using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProtoType.Tests
{
    [TestClass]
    public class VocabuloryStoreFactoryTests
    {
        [TestMethod]
        public void Check_Stores_Are_Different()
        {
            IVocabularyStore vocabularyStore1 = VocabuloryStoreFactory.getVocabularyStore();
            IVocabularyStore vocabularyStore2 = VocabuloryStoreFactory.getVocabularyStore();
            Assert.AreNotEqual(vocabularyStore1, vocabularyStore2);
        }

        public void Check_Stores_Are_Different_COntain_Base_Words()
        {
            IVocabularyStore vocabularyStore1 = VocabuloryStoreFactory.getVocabularyStore();
            IVocabularyStore vocabularyStore2 = VocabuloryStoreFactory.getVocabularyStore();

            Assert.AreEqual("n. Add on", vocabularyStore1.getMeaning("feature"));
            Assert.AreEqual("n. Slogging for the Whole night", vocabularyStore1.getMeaning("night"));

            Assert.AreEqual("n. Add on", vocabularyStore2.getMeaning("feature"));
            Assert.AreEqual("n. Slogging for the Whole night", vocabularyStore2.getMeaning("night"));

        }
    }
}
