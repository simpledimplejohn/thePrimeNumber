using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Tracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleCheckerTests
  {
    [TestMethod]
    public void Constructor_InitializesValuesCorrectly()
    {
      TriangleChecker triangle = new TriangleChecker(3, 4, 5);

      Assert.AreEqual(triangle.side1, 3);
      Assert.AreEqual(triangle.side2, 4);
      Assert.AreEqual(triangle.side3, 5);
    }

    [TestMethod]
    public void IsEquilateral_ChecksForAnEquilateralTriangle_ReturnsTrueWhenSidesEqual()
    {
      TriangleChecker triangle = new TriangleChecker(10, 10, 10);
      Assert.AreEqual(triangle.IsEquilateral(), true);
    }

    [TestMethod]
    public void IsEquilateral_ChecksForNotAnEquilateralTriangle_ReturnsFalseWhenSidesNotEqual()
    {
      TriangleChecker triangle = new TriangleChecker(10, 11, 10);
      Assert.AreEqual(triangle.IsEquilateral(), false);
    }

    [TestMethod]
    public void IsIsosceles_ChecksForAnIsoscelesTriangle_ReturnsTrueWhenTwoSidesMatch()
    {
      TriangleChecker triangle1 = new TriangleChecker(11, 11, 10);
      Assert.AreEqual(triangle1.IsIsosceles(), true);

      TriangleChecker triangle2 = new TriangleChecker(12, 11, 12);
      Assert.AreEqual(triangle2.IsIsosceles(), true);

      TriangleChecker triangle3 = new TriangleChecker(10, 9, 9);
      Assert.AreEqual(triangle3.IsIsosceles(), true);
    }

    [TestMethod]
    public void IsIsosceles_ChecksForAnIsoscelesTriangle_ReturnsFalseWhenNoSidesMatch()
    {
      TriangleChecker triangle = new TriangleChecker(3, 4, 5);
      Assert.AreEqual(triangle.IsIsosceles(), false);
    }

    [TestMethod]
    public void IsIsosceles_ChecksForAnIsoscelesTriangle_ReturnsFalseWhenAllSidesMatch()
    {
      TriangleChecker triangle = new TriangleChecker(3, 3, 3);
      Assert.AreEqual(triangle.IsIsosceles(), false);
    }
    [TestMethod]
    public void IsIsosceles_ChecksForAnIsoscelesTriangle_ReturnsFalseWhenTwoSidesAreLessThanTheHypotenuse()
    {
      TriangleChecker triangle1 = new TriangleChecker(3, 3, 7);
      Assert.AreEqual(triangle1.IsIsosceles(), false);

      TriangleChecker triangle2 = new TriangleChecker(3, 7, 3);
      Assert.AreEqual(triangle2.IsIsosceles(), false);

      TriangleChecker triangle3 = new TriangleChecker(7, 3, 3);
      Assert.AreEqual(triangle3.IsIsosceles(), false);
    }


    [TestMethod]
    public void IsScalene_ChecksForAScaleneTriangle_ReturnsTrueWhenNoSidesMatch()
    {
      TriangleChecker triangle = new TriangleChecker(3, 4, 5);
      Assert.AreEqual(triangle.IsScalene(), true);
    }

    [TestMethod]
    public void IsScalene_ChecksForAScaleneTriangle_ReturnsFalseWhenAnyTwoSidesAreLessThanTheThird()
    {
      TriangleChecker triangle1 = new TriangleChecker (2, 1, 4);
      Assert.AreEqual(triangle1.IsScalene(), false);

      TriangleChecker triangle2 = new TriangleChecker (2, 4, 1);
      Assert.AreEqual(triangle2.IsScalene(), false);
      
      TriangleChecker triangle3 = new TriangleChecker (4, 2, 1);
      Assert.AreEqual(triangle3.IsScalene(), false);
    }

    [TestMethod]
    public void IsScalene_ChecksForAScaleneTriangle_ReturnsFalseWhenAnyTwoSidesAddedTogetherAreEqualToTheThirdSide()
    {
      TriangleChecker triangle1 = new TriangleChecker (2, 3, 5);
      Assert.AreEqual(triangle1.IsScalene(), false);

      TriangleChecker triangle2 = new TriangleChecker (2, 5, 3);
      Assert.AreEqual(triangle2.IsScalene(), false);

      TriangleChecker triangle3 = new TriangleChecker (5, 3, 2);
      Assert.AreEqual(triangle3.IsScalene(), false);
    }

    [TestMethod]
    public void IsScalene_ChecksForAScaleneTriangle_ReturnsFalseIfEquilateral()
    {
      TriangleChecker triangle1 = new TriangleChecker(2, 2, 2);
      Assert.AreEqual(triangle1.IsScalene(), false);
    }
  }
}