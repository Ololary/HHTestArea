namespace HHTestArea.UnitTests
{
    [TestClass]
    public class TrungleTests
    {
        [TestMethod]
        public void TrungleArrayTests()
        {
            Assert.AreEqual(6,ShapeArea.Area(new Trungle(3,4,5)));
            Assert.AreEqual(12, ShapeArea.Area(new Trungle(6,5,5)));
            Assert.AreEqual(24, ShapeArea.Area(new Trungle(15, 13, 4)));
            Assert.AreEqual(90, ShapeArea.Area(new Trungle(53, 51, 4)));

        }
        [TestMethod]
        public void isTrungleStraight()
        {
         var trungle1 = new Trungle(3,4,5);
         var trungle2 = new Trungle(6,5,5);
         var trungle3 = new Trungle(7,5,5);

         Assert.IsTrue(trungle1.isTrungleStright());
         Assert.IsFalse(trungle2.isTrungleStright());
         Assert.IsFalse(trungle3.isTrungleStright());

        }
    }
}