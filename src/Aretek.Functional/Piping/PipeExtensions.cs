namespace Aretek.Functional.Piping;

public static class PipeExtensions
{
    /// <summary>
    /// Calls the function with the input
    /// </summary>
    /// <param name="input">The input</param>
    /// <param name="func">The function to be called</param>
    /// <typeparam name="TInput">The input type</typeparam>
    /// <typeparam name="TOutput">The return type of the function</typeparam>
    /// <returns>The return value of the function</returns>
    public static TOutput Pipe<TInput, TOutput>(
        this TInput input,
        Func<TInput, TOutput> func
    ) => func(input);
}