
namespace HHTestArea.UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]

        public void CircleAreaTests()
        {
            var circle1 = new Circle(5);
            var circle2 = new Circle(2);

            Assert.AreEqual(78.5 , circle1.Area());
            Assert.AreEqual(12.56, circle2.Area());

        }

    }
}
