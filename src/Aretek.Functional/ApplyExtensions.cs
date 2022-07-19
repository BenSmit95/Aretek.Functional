namespace Aretek.Functional;

public static class ApplyExtensions
{
    #region 2 params

    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <returns>The function with the first argument applied</returns>
    public static Action<T2> Apply<T1, T2>(
        this Action<T1, T2> func,
        T1 p1
    ) => p2 => func(p1, p2);
    
    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="TResult">The function return type</typeparam>
    /// <returns>The function with the first argument applied</returns>
    public static Func<T2, TResult> Apply<T1, T2, TResult>(
        this Func<T1, T2, TResult> func,
        T1 p1
    ) => (p2) => func(p1, p2);

    #endregion

    #region 3 params

    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <returns>The function with the first argument applied</returns>
    public static Action<T2, T3> Apply<T1, T2, T3>(
        this Action<T1, T2, T3> func,
        T1 p1
    ) => (p2, p3) => func(p1, p2, p3);
    
    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="TResult">The function return type</typeparam>
    /// <returns>The function with the first argument applied</returns>
    public static Func<T2, T3, TResult> Apply<T1, T2, T3, TResult>(
        this Func<T1, T2, T3, TResult> func,
        T1 p1
    ) => (p2, p3) => func(p1, p2, p3);
    
    /// <summary>
    /// Takes the function and returns another function with the first 2 arguments applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <param name="p2">The second argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <returns>The function with the first 2 arguments applied</returns>
    public static Action<T3> Apply<T1, T2, T3>(
        this Action<T1, T2, T3> func,
        T1 p1,
        T2 p2
    ) => (p3) => func(p1, p2, p3);
    
    /// <summary>
    /// Takes the function and returns another function with the first 2 arguments applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <param name="p2">The second argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="TResult">The function return type</typeparam>
    /// <returns>The function with the first 2 arguments applied</returns>
    public static Func<T3, TResult> Apply<T1, T2, T3, TResult>(
        this Func<T1, T2, T3, TResult> func,
        T1 p1,
        T2 p2
    ) => (p3) => func(p1, p2, p3);
    
    #endregion

    #region 4 params
    
    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="T4">The fourth parameter type</typeparam>
    /// <returns>The function with the first argument applied</returns>
    public static Action<T2, T3, T4> Apply<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4> func,
        T1 p1
    ) => (p2, p3, p4) => func(p1, p2, p3, p4);
    
    /// <summary>
    /// Takes the function and returns another function with the first argument applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="T4">The fourth parameter type</typeparam>
    /// <typeparam name="TResult">The function return type</typeparam>
    /// <returns>The function with the first argument applied</returns>
    public static Func<T2, T3, T4, TResult> Apply<T1, T2, T3, T4, TResult>(
        this Func<T1, T2, T3, T4, TResult> func,
        T1 p1
    ) => (p2, p3, p4) => func(p1, p2, p3, p4);
    
    /// <summary>
    /// Takes the function and returns another function with the first 2 arguments applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <param name="p2">The second argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="T4">The fourth parameter type</typeparam>
    /// <returns>The function with the first 2 arguments applied</returns>
    public static Action<T3, T4> Apply<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4> func,
        T1 p1,
        T2 p2
    ) => (p3, p4) => func(p1, p2, p3, p4);
    
    /// <summary>
    /// Takes the function and returns another function with the first 2 arguments applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <param name="p2">The second argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="T4">The fourth parameter type</typeparam>
    /// <typeparam name="TResult">The function return type</typeparam>
    /// <returns>The function with the first 2 arguments applied</returns>
    public static Func<T3, T4, TResult> Apply<T1, T2, T3, T4, TResult>(
        this Func<T1, T2, T3, T4, TResult> func,
        T1 p1,
        T2 p2
    ) => (p3, p4) => func(p1, p2, p3, p4);

    /// <summary>
    /// Takes the function and returns another function with the first 3 arguments applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <param name="p2">The second argument</param>
    /// <param name="p3">The third argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="T4">The fourth parameter type</typeparam>
    /// <returns>The function with the first 3 arguments applied</returns>
    public static Action<T4> Apply<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4> func,
        T1 p1,
        T2 p2,
        T3 p3
    ) => (p4) => func(p1, p2, p3, p4);
    
    /// <summary>
    /// Takes the function and returns another function with the first 3 arguments applied
    /// </summary>
    /// <param name="func">The function</param>
    /// <param name="p1">The first argument</param>
    /// <param name="p2">The second argument</param>
    /// <param name="p3">The third argument</param>
    /// <typeparam name="T1">The first parameter type</typeparam>
    /// <typeparam name="T2">The second parameter type</typeparam>
    /// <typeparam name="T3">The third parameter type</typeparam>
    /// <typeparam name="T4">The fourth parameter type</typeparam>
    /// <typeparam name="TResult">The function return type</typeparam>
    /// <returns>The function with the first 3 arguments applied</returns>
    public static Func<T4, TResult> Apply<T1, T2, T3, T4, TResult>(
        this Func<T1, T2, T3, T4, TResult> func,
        T1 p1,
        T2 p2,
        T3 p3
    ) => (p4) => func(p1, p2, p3, p4);

    #endregion
}