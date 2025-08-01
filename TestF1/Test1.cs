
using prjF1indexers;

namespace TestF1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestID()
        {
            F1RaceDetails f1 = new F1RaceDetails(44, 75, "Spa Belguim", "Standard");
            Assert.AreEqual(f1[0], 44);
        }

        [TestMethod]
        public void TestUpdatedWinners()
        {
            F1RaceDetails f1 = new F1RaceDetails(44, 75, "Spa Belguim", "Standard");
            f1[1] = 80;
            Assert.AreEqual(f1[1], 80);
        }

        [TestMethod]
        public void TestUpdateName()
        {
            F1RaceDetails f1 = new F1RaceDetails(44, 75, "Spa Belguim", "Standard");
            f1[2] = "Spa";
            Assert.AreEqual(f1[2], "Spa");
        }

        [TestMethod]
        public void testDifficulty()
        {
            F1RaceDetails f1 = new F1RaceDetails(44, 75, "Spa Belguim", "Standard");
            Assert.AreEqual(f1["difficulty"], "Standard"); //string index
        }

        [TestMethod]
        public void TestLaps()
        {
            F1RaceDetails f1 = new F1RaceDetails(44, 75, "Spa Belguim", "Standard");
            Assert.AreNotEqual(f1[0], 42);
        }
    }
}
