using Aretek.Functional.Piping;

namespace Aretek.Functional.Tests.Piping;

public class PipeTests
{
    [Fact(DisplayName = "Pipe should return the result of the function")]
    public void Pipe_Should_Return_Result()
    {
        bool Func(string s) => s.Length > 0;

        var result = "Test string"
            .Pipe(Func);

        result.Should().BeTrue();
    }
}