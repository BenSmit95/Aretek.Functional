namespace Aretek.Functional.Tests.PartialApplication;

public class Apply4Tests
{
    [Fact(DisplayName = "Apply should apply the first parameter to Action")]
    public void Apply_Should_Apply_First_Parameter_To_Action()
    {
        var number = 1;

        var func = (int num1, int num2, int num3, int num4) => { number += (num1 + num2 + num3 + num4); };

        var applied = func.Apply(1);

        applied(2, 3, 5);

        // 1 + 1 + 2 + 3 + 5 = 12
        number.Should().Be(12);
    }

    [Fact(DisplayName = "Apply should apply the first parameter to Func")]
    public void Apply_Should_Apply_First_Parameter_To_Func()
    {
        var func = (int num1, int num2, int num3, int num4) => num1 + num2 + num3 + num4;

        var applied = func.Apply(1);
        var applied2 = func.Apply(10);

        // 1 + 5 + 10 + 15 = 31
        applied(5, 10, 15).Should().Be(31);

        // 10 + 15 + 20 + 25 = 70
        applied2(15, 20, 25).Should().Be(70);
    }

    [Fact(DisplayName = "Apply should apply the first 2 parameters to Action")]
    public void Apply_Should_Apply_First_2_Parameters_To_Action()
    {
        var number = 1;


        var func = (int num1, int num2, int num3, int num4) => { number += (num1 + num2 + num3 + num4); };

        var applied = func.Apply(1, 5);

        applied(3, 5);

        // 1 + 1 + 5 + 3 + 5 = 15
        number.Should().Be(15);
    }

    [Fact(DisplayName = "Apply should apply the first 2 parameters to Func")]
    public void Apply_Should_Apply_First_2_Parameters_To_Func()
    {
        var func = (int num1, int num2, int num3, int num4) => num1 + num2 + num3 + num4;

        var applied = func.Apply(1, 10);
        var applied2 = func.Apply(10, 20);

        // 1 + 10 + 15 + 20 = 46
        applied(15, 20).Should().Be(46);

        // 10 + 20 + 25 + 30 = 85
        applied2(25, 30).Should().Be(85);
    }

    [Fact(DisplayName = "Apply should apply the first 3 parameters to Action")]
    public void Apply_Should_Apply_First_3_Parameters_To_Action()
    {
        var number = 1;
        
        var func = (int num1, int num2, int num3, int num4) => { number += (num1 + num2 + num3 + num4); };
        
        var applied = func.Apply(1, 5, 10);

        applied(3);

        // 1 + 1 + 5 + 10 + 3 = 20
        number.Should().Be(20);
    }

    [Fact(DisplayName = "Apply should apply the first 3 parameters to Func")]
    public void Apply_Should_Apply_First_3_Parameters_To_Func()
    {
        var func = (int num1, int num2, int num3, int num4) => num1 + num2 + num3 + num4;

        var applied = func.Apply(1, 10, 11);
        var applied2 = func.Apply(10, 20, 21);

        // 1 + 10 + 11 + 15 = 37
        applied(15).Should().Be(37);

        // 10 + 20 + 21 + 25 = 76
        applied2(25).Should().Be(76);
    }
}