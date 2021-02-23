using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.TestTools
{
  [TestClass]
  public class TriangleTypesTests
  {
    [TestMethod]
    public void TriangleTypes_InputsThreeNumbers_True()
    {
      TriangleTypes testTriangleTypes = new TriangleTypes();
      Assert.AreEqual(true, testTriangleTypes.IsATriangle(3, 4, 5));
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
