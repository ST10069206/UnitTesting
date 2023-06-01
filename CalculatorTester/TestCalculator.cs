using CalculatorApp;

// to add unit test, right click solution, select add new project>tests> NUnit
// select build> build solution
// check if tests is there under dependencies> projects.
// select view> tests, to view test menu.

// if static classes, then you dont need an object of the class
// ensure methods are public so that you can access it in the test. 

namespace CalculatorTester;

//1. Arrange
//      -declare variables
//      -assign values
//      -determine expected output

//2. Act/ Actual
//      -execute actual process
//      -get actual output

//3. Assert
//      -check if actual is the same as expected.
//      (If they match the test will pass, if they dont match the test will fail)

public class TestCalculator
{
    [SetUp]
    public void Setup()
    {
        // you can declare variable within here which you can use in different methods but it is not neccesary. 
        // (global variables). 
    }

    [Test]
    public void Test1()
    {
        // Arrange
        int num1 = 1;
        int num2 = 1;
        int expected = 2; //keep it simple for addition. 

        // Act/ Actual
        int actual = num1 + num2;

        // Assert
        // assert: if it is true, if are equal(only checks if the value is equal
        // if it is are same(checks if data type is the same).

        Assert.AreEqual(expected, actual); //checking if the values are the same. 
    }

    [Test]
    public void TestSum()
    {
        // Arrange
        double x = 1;
        double y = 1;
        double expected = 2;

        // Act/ Actual
        Calculator c = new Calculator();
        double actual = c.SumOfNumbers(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestProduct()
    {
        // Arrange
        double x = 2;
        double y = 3;
        double expected = 6;

        // Act/ Actual
        Calculator c = new Calculator();
        double actual = c.ProductOfNumbers(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void TestDifference()
    {
        // Arrange
        double x = 2;
        double y = 1;
        double expected = 1;

        // Act/ Actual
        Calculator c = new Calculator();
        double actual = c.DifferencefNumbers(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
