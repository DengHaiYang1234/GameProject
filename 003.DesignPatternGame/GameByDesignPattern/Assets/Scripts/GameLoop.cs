using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    private SceneStateController _stateController;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Use this for initialization
    void Start ()
    {
        _stateController = new SceneStateController();
        _stateController.SetState(new StartState(_stateController),false);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    _stateController.StateRunning();
	}
}
