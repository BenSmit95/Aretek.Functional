using Aretek.Functional.PartialApplication;

namespace Aretek.Functional.Tests.PartialApplication;

public class ApplyTests
{
    [Fact(DisplayName = "Apply should apply the first parameter")]
    public void Apply_Should_Apply_First_Parameter()
    {
        var func = (int num1, int num2) => num1 + num2;

        var applied = func.Apply(1);
        var applied2 = func.Apply(10);

        applied(5).Should().Be(6);
        applied2(15).Should().Be(25);
    }
}