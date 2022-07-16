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

    /// <summary>
    /// Calls the function with the input
    /// </summary>
    /// <param name="input">The input</param>
    /// <param name="func">The function to be called</param>
    /// <typeparam name="TInput">The input type</typeparam>
    /// <typeparam name="TOutput">The return type of the function</typeparam>
    /// <returns>The return value of the function wrapped in a Task</returns>
    public static Task<TOutput> PipeAsync<TInput, TOutput>(
        this TInput input,
        Func<TInput, Task<TOutput>> func
    ) => Pipe(input, func);
    
    /// <summary>
    /// Calls function with result of the awaited input task
    /// </summary>
    /// <param name="input">The input, wrapped in a Task</param>
    /// <param name="func">The function to be called</param>
    /// <typeparam name="TInput">The input type</typeparam>
    /// <typeparam name="TOutput">The return type of the function</typeparam>
    /// <returns>The return value of the function wrapped in a Task</returns>
    public static async Task<TOutput> PipeAsync<TInput, TOutput>(
        this Task<TInput> input,
        Func<TInput, TOutput> func
    ) => Pipe(await input, func);
    
    /// <summary>
    /// Await input Task and function output Task
    /// </summary>
    /// <param name="input">The input, wrapped in a Task</param>
    /// <param name="func">The function to be called</param>
    /// <typeparam name="TInput">The input type</typeparam>
    /// <typeparam name="TOutput">The return type of the function</typeparam>
    /// <returns>The return value of the function wrapped in a Task</returns>
    public static async Task<TOutput> PipeAsync<TInput, TOutput>(
        this Task<TInput> input,
        Func<TInput, Task<TOutput>> func
    ) => await Pipe(await input, func);
}