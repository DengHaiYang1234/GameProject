using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStateController
{
    private ISceneState _state;

    public void StateRunning()
    {
        if (_state != null)
        {
            _state.StateRunning();
        }
    }

}
