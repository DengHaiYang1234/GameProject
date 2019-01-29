using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM01State_Test : MonoBehaviour
{
    private void Start()
    {
        Context_Test _context = new Context_Test();
        _context.SetState(new ConcreteStateA_Test(_context));

        _context.Handle(5);
        _context.Handle(15);
        _context.Handle(30);
        _context.Handle(5);
        _context.Handle(2);
    }
}


public class Context_Test
{
    private IState_Test _state;

    public void SetState(IState_Test state)
    {
        _state = state;
    }

    public void Handle(int arg)
    {
        _state.Handle(arg);
    }
}


public interface IState_Test
{
    void Handle(int arg);
}

public class ConcreteStateA_Test : IState_Test
{
    private Context_Test _context;

    public ConcreteStateA_Test(Context_Test context)
    {
        _context = context;
    }

    public void Handle(int arg)
    {
        Debug.Log("ConcreteStateA_Test.Handle:" + arg);
        if (arg > 10)
        {
            _context.SetState(new ConcreteStateB_Test(_context));
        }
    }
}

public class ConcreteStateB_Test : IState_Test
{
    private Context_Test _context;

    public ConcreteStateB_Test(Context_Test context)
    {
        _context = context;
    }

    public void Handle(int arg)
    {
        Debug.Log("ConcreteStateB_Test.Handle:" + arg);
        if (arg < 10)
        {
            _context.SetState(new ConcreteStateA_Test(_context));
        }
    }
}
