namespace Aretek.Functional.Tests.PartialApplication;

public class Apply3Tests
{
    [Fact(DisplayName = "Apply should apply the first parameter to Action")]
    public void Apply_Should_Apply_First_Parameter_To_Action()
    {
        var number = 1;

        var func = (int num1, int num2, int num3) =>
        {
            number += (num1 + num2 + num3);
        };

        var applied = func.Apply(1);

        applied(2, 3);
        
        // 1 + 1 + 2 + 3 = 7
        number.Should().Be(7);
    }
    
    [Fact(DisplayName = "Apply should apply the first parameter to Func")]
    public void Apply_Should_Apply_First_Parameter_To_Func()
    {
        var func = (int num1, int num2, int num3) => num1 + num2 + num3;

        var applied = func.Apply(1);
        var applied2 = func.Apply(10);

        // 1 + 5 + 10 = 16
        applied(5, 10).Should().Be(16);
        
        // 10 + 15 + 20 = 45
        applied2(15, 20).Should().Be(45);
    }
    
    [Fact(DisplayName = "Apply should apply the first 2 parameters to Action")]
    public void Apply_Should_Apply_First_2_Parameters_To_Action()
    {
        var number = 1;

        var func = (int num1, int num2, int num3) =>
        {
            number += (num1 + num2 + num3);
        };

        var applied = func.Apply(1, 5);

        applied(3);
        
        // 1 + 1 + 5 + 3 = 10
        number.Should().Be(10);
    }
    
    [Fact(DisplayName = "Apply should apply the first 2 parameters to Func")]
    public void Apply_Should_Apply_First_2_Parameters_To_Func()
    {
        var func = (int num1, int num2, int num3) => num1 + num2 + num3;

        var applied = func.Apply(1, 10);
        var applied2 = func.Apply(10, 20);

        // 1 + 10 + 15 = 26
        applied(15).Should().Be(26);
        
        // 10 + 20 + 25 = 55
        applied2(25).Should().Be(55);
    }
}