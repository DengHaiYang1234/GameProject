using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    private ISceneState _state;

    private AsyncOperation _ao;

    private bool isStateStart = true;

    public void SetState(ISceneState state,bool isLoadScenen = true)
    {
        if (_state != null)
        {
            _state.StateEnd(); //上一个状态结束
        }

        _state = state;

        if (isLoadScenen)
        {
            _ao = SceneManager.LoadSceneAsync(_state.SceneName); //异步加载场景
            isStateStart = false;
        }
        else
        {
            _state.StateStart();
            isStateStart = true;
        }
    }

    public void StateRunning()
    {
        if (_ao != null && !_ao.isDone) return;

        if (!isStateStart && _ao != null && _ao.isDone)
        {
            _state.StateStart(); //下一场景切换
            isStateStart = true;
        }

        if (_state != null)
        {
            _state.StateRunning();
        }
    }

}
