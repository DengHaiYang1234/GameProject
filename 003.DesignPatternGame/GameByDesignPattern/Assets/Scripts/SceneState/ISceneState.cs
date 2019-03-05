using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISceneState
{
    private string _sceneName;

    private SceneStateController _controller;

    public ISceneState(string sceneName,SceneStateController controller)
    {
        _sceneName = sceneName;
        _controller = controller;
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
