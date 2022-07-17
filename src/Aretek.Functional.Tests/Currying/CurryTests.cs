using Aretek.Functional.Currying;

namespace Aretek.Functional.Tests.Currying;

public class CurryTests
{
    [Fact(DisplayName = "Curried should apply arguments")]
    public void Curried_Should_Apply_Arguments()
    {
        var func = (int num1, int num2) => num1 + num2;

        var curried = func.Curried();

        var c1 = curried(1);
        var c2 = curried(2);

        c1(5).Should().Be(6);
        c2(8).Should().Be(10);
    }
}