using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DM01StateDesign : MonoBehaviour
{
    private void Start()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));

        context.Handle(4);
        context.Handle(22);
        context.Handle(888);
        context.Handle(15);
        context.Handle(1);
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
        if (arg > 20)
        {
            Debug.LogError("===A切换至B===,当前参数：" + arg);
            _context.SetState(new ConcreteStateB(_context)); //状态切换
        }
        else
        {
            Debug.LogError("A处理：" + arg);
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
        if (arg < 20)
        {
            Debug.LogError("===B切换至A===,当前参数：" + arg);
            _context.SetState(new ConcreteStateA(_context)); //状态切换
        }
        else
        {
            Debug.LogError("B处理：" + arg);
        }
    }
}
