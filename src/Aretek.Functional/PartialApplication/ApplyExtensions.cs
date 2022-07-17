namespace Aretek.Functional.PartialApplication;

public static class ApplyExtensions
{
    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="TResult">The return type</typeparam>
    /// <returns>A func that takes the second parameter type and returns the return type</returns>
    public static Func<T2, TResult> Apply<T1, T2, TResult>(
        this Func<T1, T2, TResult> func,
        T1 p1
    ) => (p2) => func(p1, p2);
}