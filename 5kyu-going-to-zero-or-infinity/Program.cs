using System.Numerics;
public class Suite
{
public static double CalcIntFactor(int n, int end) 
{
    double factor = 1;
    for(int i = n; i >= end; i--)
    {
        if (n == 0) break;
        factor = (factor / i);
    }
    return factor;
}
public static double AddFactors(int n)
{
    int limit = n - (n - 2);
    double summary = 1;
    for (int i = n; i >= limit; i--)
    {
        summary += CalcIntFactor(n, i);
    }
    return summary;
}

public static double going(int n)
{

    
    return AddFactors(n);
}
 
}
