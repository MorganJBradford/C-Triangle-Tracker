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
      Assert.AreEqual("Not a triangle.", testTriangle.IsATriangle());
    }

    [TestMethod]
    public void Triangle_AreAllSidesEqual_True()
    {
      Triangle testTriangle = new Triangle(4, 4, 4);
      Assert.AreEqual("Is an equilateral triangle", testTriangle.IsATriangle());
    }

    [TestMethod]

    public void Triangle_TwoSidesAreEqual_True()
    {
      Triangle testTriangle = new Triangle(4, 4, 7);
      Assert.AreEqual("Is an isosceles triangle", testTriangle.IsATriangle());
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
