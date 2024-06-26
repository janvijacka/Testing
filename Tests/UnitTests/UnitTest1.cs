using Calculator;

namespace UnitTests {
    [TestClass]
    public class UnitTest1 {
        //Bìžná struktura testù
        //Do dependencies zadat Add project reference
        //[AssemblyInitialize]
        //[ClassInitialize]
        //[TestInitialize]
        //[TestMethod]
        //[TestMethod]
        //[TestCleanup]
        //[ClassCleanup]
        //[AssemblyCleanup]

        Calc calc;
        [TestInitialize]
        public void Initialise() {
            calc = new Calc();
        }

        [TestMethod]
        public void TestAdd() {
            int actual = calc.Add(5, 8);
            Assert.AreEqual(13, actual);
            //Assert.AreEqual(13, calc.Add(5, 8));
        }
    }
}