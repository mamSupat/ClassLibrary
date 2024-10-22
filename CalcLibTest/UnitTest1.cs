using CalculatorLibrary;
namespace CalcLibTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        int testNum1 = 2;
        int testNum2 = 3;
        int sum = testNum1 + testNum2;
        int Result = CalculatorLibrary.CalculatorLibrary.Add(testNum1,testNum2);
        Assert.AreEqual(Result, sum);
    }
}