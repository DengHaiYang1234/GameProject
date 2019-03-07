using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

//策略模式  多用于数值预算
public class DM03StategyDesing : MonoBehaviour
{
    private void Start()
    {
        int x = 1;
        int y = 2;

        StategyContext sc = new StategyContext(new Div());

        Debug.LogError(sc.Cal(x, y));
    }
}

public class StategyContext
{
    private ISoultion _soultion;

    public StategyContext(ISoultion soultion)
    {
        _soultion = soultion;
    }

    public int Cal(int x,int y)
    {
        return _soultion.Cal(x, y);
    }
}

public interface ISoultion
{
    int Cal(int x,int y);
}

public class Sum : ISoultion
{
    public int Cal(int x, int y)
    {
        Debug.Log("+");
        return x + y;
    }
}

public class Sub : ISoultion
{
    public int Cal(int x, int y)
    {

        Debug.Log("-");
        return x - y;
    }
}

public class Mul : ISoultion
{
    public int Cal(int x, int y)
    {
        Debug.Log("*");
        return x * y;
    }
}

public class Div : ISoultion
{
    public int Cal(int x, int y)
    {
        Debug.Log("/");
        return x / y;
    }
}
