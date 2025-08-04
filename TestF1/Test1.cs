
using prjF1indexers;

namespace TestF1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestID()
        {
            cats cat = new cats(1, "Ashe", "Gray");
            Assert.AreEqual(cat[0], 44);
        }

        [TestMethod]
        public void TestUpdatedWinners()
        {
            cats f1 = new cats(80,"Blu", "Russian blue");
            f1[1] = 44;
            Assert.AreEqual(f1[1], 44);
        }

        [TestMethod]
        public void TestUpdateName()
        {
            cats f1 = new cats(3, "Sammy", "Calico");
            f1[2] = "Spa";
            Assert.AreEqual(f1[2], "Spa");
        }

        [TestMethod]
        public void testDifficulty()
        {
            cats cat = new cats(1, "Ashe", "Gray");
            Assert.AreEqual(cat["Name"], "Ashe"); //string index
        }

        [TestMethod]
        public void TestLaps()
        {
            cats cat = new cats(1, "Ashe", "Gray");
            Assert.AreNotEqual(cat[0], 44);
        }
    }
}
