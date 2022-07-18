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
    
    [Fact(DisplayName = "PipeAsync should handle output Task")]
    public async Task Pipe_Async_Should_Handle_Output_Task()
    {
        Task<bool> Func(string s) => Task.FromResult(s.Length > 0);

        var result = "Test string"
            .PipeAsync(Func);

        result.Should().BeOfType<Task<bool>>();

        (await result).Should().Be(true);
    }
    
    [Fact(DisplayName = "PipeAsync should handle input Task")]
    public async Task Pipe_Async_Should_Handle_Input_Task()
    {
        bool Func(string s) => s.Length > 0;

        var input = Task.FromResult("Test string");
        
        var result = input
            .PipeAsync(Func);
        
        (await result).Should().Be(true);
    }
    
    [Fact(DisplayName = "PipeAsync should handle input Task and output Task")]
    public async Task Pipe_Async_Should_Handle_Input_Task_And_Output_Task()
    {
        Task<bool> Func(string s) => Task.FromResult(s.Length > 0);

        var input = Task.FromResult("Test string");
        
        var result = input
            .PipeAsync(Func);
        
        (await result).Should().Be(true);
    }
}