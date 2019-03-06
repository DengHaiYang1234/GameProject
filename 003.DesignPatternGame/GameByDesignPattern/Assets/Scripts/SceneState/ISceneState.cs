using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISceneState
{
    private string _sceneName;

    protected SceneStateController _controller;

    public ISceneState(string sceneName,SceneStateController controller)
    {
        _sceneName = sceneName;
        _controller = controller;
    }

    public string SceneName
    {
        get { return _sceneName; }
    }

    public virtual void StateStart()
    {
        
    }

    public virtual void StateRunning()
    {
        
    }

    public virtual void StateEnd()
    {

    }

}
