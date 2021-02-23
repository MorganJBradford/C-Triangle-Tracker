using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_DoThreeNumbersMakeATriangle_False()
    {
      Triangle testTriangle = new Triangle(2, 2, 8);
      Assert.AreEqual(false, testTriangle.IsATriangle(2, 2, 8));
    }
  }
}

// ...

// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }

// ...
