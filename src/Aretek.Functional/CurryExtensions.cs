namespace Aretek.Functional;

public static class CurryExtensions
{
    /// <summary>
    /// Turns a regular function into a curried function
    /// </summary>
    /// <param name="func">The function that will be curried</param>
    /// <typeparam name="T1">First argument type</typeparam>
    /// <typeparam name="T2">Second argument type</typeparam>
    /// <typeparam name="TResult">Result type</typeparam>
    /// <returns>The curried function</returns>
    public static Func<T1, Func<T2, TResult>> Curried<T1, T2, TResult>(
        this Func<T1, T2, TResult> func
    ) => t1 => t2 => func(t1, t2);
}