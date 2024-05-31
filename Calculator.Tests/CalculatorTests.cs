using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Calculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(6L, Add.Eval(1L, 5L));
    }
    [Fact]
    public void TestSubtract()
    {
        Assert.Equal(4L, Subtract.Eval(5L, 1L));
    }
    [Fact]
    public void TestMult()
    {
        Assert.Equal(6L, Multiply.Eval(2L, 3L));
    }
    [Fact]
    public void TestAddOperation()
    {
        Assert.Equal(8, Evaluator.Eval("+", 6, 2));
    }

    [Fact]
    public void TestSubtractOperation()
    {
        Assert.Equal(4, Evaluator.Eval("-", 6, 2));
    }
    [Fact]
    public void TestMultiplyOperation()
    {
        Assert.Equal(12, Evaluator.Eval("*", 6, 2));
    }

    [Fact]
    public void TestDefaultCase()
    {
        Assert.Throws<Exception>(() => Evaluator.Eval("%", 6, 2));
    }

    [Fact]
    public void TestExitCase()
    {
        StringReader sr = new StringReader("4"); 
        Console.SetIn(sr);
        Assert.Equal(false,Program.execute);
    }




}