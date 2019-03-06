using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class BattleState: ISceneState
{


    public BattleState(SceneStateController controller) : base("03BattleScene", controller)
    {

    }

    public override void StateStart()
    {
        Debug.LogError("进入到BattleState");
        GameFacade.Instance.Init();
    }

    public override void StateRunning()
    {
        if (GameFacade.Instance.isGameOver)
        {
            _controller.SetState(new MainMenuState(_controller));
        }

        GameFacade.Instance.Update();
    }

    public override void StateEnd()
    {
        GameFacade.Instance.Release();
    }
}
