using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class MainMenuState: ISceneState
{
    public MainMenuState(SceneStateController controller) : base("02MainMenuScene", controller)
    {

    }

    public override void StateStart()
    {
        Debug.LogError("进入MainMenuState");


        GameObject.Find("StartBtn").GetComponent<Button>().onClick.AddListener(OnStartBtnClick);
    }

    private void OnStartBtnClick()
    {
        _controller.SetState(new BattleState(_controller));
    }
}
