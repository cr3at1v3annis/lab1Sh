namespace tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestExercise2()
    {
        double first = 1.5;
        double second = 5;
        Rectangle rec = new Rectangle(first, second);
        Assert.AreEqual(7.5, rec.Area);
        Assert.AreEqual(13, rec.Perimeter);
    }

    [TestMethod]
    public void TestExercise3First()
    {
        Point a = new Point(0, 0);
        Point b = new Point(3, 0);
        Point c = new Point(0, 4);
        Figure f = new Figure(a, b, c);
        Assert.AreEqual(12, f.getPerimeter());
        Assert.AreEqual("rectangle", f.name);
    }

    [TestMethod]
    public void TestExercise3Second()
    {
        Point a = new Point(0, 1);
        Point b = new Point(0, 0);
        Point c = new Point(1, 0);
        Point d = new Point(1, 1);
        Figure f = new Figure(a, b, c, d);
        Assert.AreEqual(4, f.getPerimeter());
        Assert.AreEqual("square", f.name);
    }

    [TestMethod]
    public void TestExercise3Third()
    {
        Point a = new Point(0, 0);
        Point b = new Point(0, 2);
        Point c = new Point(3, 6);
        Point d = new Point(5, 6);
        Point e = new Point(5, 0);
        Figure f = new Figure(a, b, c, d, e);
        Assert.AreEqual(20, f.getPerimeter());
        Assert.AreEqual("pentagon", f.name);
    }
}