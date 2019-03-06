using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

class StartState : ISceneState
{
    private Image _logo;

    private float _smoothingSpeed = 1;

    private float _waitTime = 2;


    public StartState(SceneStateController controller) : base("01StartSscene",controller)
    {
        
    }

    public override void StateEnd()
    {
        base.StateEnd();
    }

    public override void StateStart()
    {
        _logo = GameObject.Find("Logo").GetComponent<Image>();
        _logo.color = Color.black;
    }

    public override void StateRunning()
    {
        _logo.color = Color.Lerp(_logo.color, Color.white, _smoothingSpeed * Time.deltaTime);
        _waitTime -= Time.deltaTime;

        if (_waitTime <= 0)
        {
            _controller.SetState(new MainMenuState(_controller));
        }
    }
}
