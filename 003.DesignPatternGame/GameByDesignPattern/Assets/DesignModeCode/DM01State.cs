using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
状态模式
*/

public class DM01State : MonoBehaviour
{
    private void Start()
    {
        Context context = new Context();

        context.SetState(new ConcreteStateA(context));

        context.Handle(5);

        context.Handle(20);

        context.Handle(30);

        context.Handle(5);

        context.Handle(6);
    }
}


public class Context
{
    private IState _state;

    public void SetState(IState state)
    {
        _state = state;
    }

    public void Handle(int arg)
    {
        _state.Handle(arg);
    }
}

public interface IState
{
    void Handle(int arg);
}

public class ConcreteStateA : IState
{
    private Context _context;
    public ConcreteStateA(Context context)
    {
        _context = context;
    }

    public void Handle(int arg)
    {
        Debug.Log("ConcreteStateA.Handle" + arg);
        if (arg > 10)
        {
            _context.SetState(new ConcreteStateB(_context));
        }
    }
}

public class ConcreteStateB : IState
{
    private Context _context;
    public ConcreteStateB(Context context)
    {
        _context = context;
    }
    public void Handle(int arg)
    {
        Debug.Log("ConcreteStateB.Handle" + arg);
        if (arg <= 10)
        {
            _context.SetState(new ConcreteStateA(_context));
        }
    }
}