namespace Aretek.Functional.Tests.PartialApplication;

public class Apply2Tests
{
    [Fact(DisplayName = "Apply should apply the first parameter to Action")]
    public void Apply_Should_Apply_First_Parameter_To_Action()
    {
        var number = 1;

        var func = (int num1, int num2) =>
        {
            number += (num1 + num2);
        };

        var applied = func.Apply(1);

        applied(2);
        
        // 1 + 1 + 2 = 4
        number.Should().Be(4);
    }
    
    [Fact(DisplayName = "Apply should apply the first parameter to Func")]
    public void Apply_Should_Apply_First_Parameter_To_Func()
    {
        var func = (int num1, int num2) => num1 + num2;

        var applied = func.Apply(1);
        var applied2 = func.Apply(10);

        applied(5).Should().Be(6);
        applied2(15).Should().Be(25);
    }
}