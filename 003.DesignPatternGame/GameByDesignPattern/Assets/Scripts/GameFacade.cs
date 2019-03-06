using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//外观模式  +  中介者模式
public class GameFacade
{
    private static GameFacade _instance = new GameFacade();

    public static GameFacade Instance {
        get { return _instance; }
    }

    private ArchievementSystem _archievementSystem;
    private CampSystem _campSystem;
    private CharacterSystem _characterSystem;
    private EnergySystem _energySystem;
    private GameEventSystem _gameEventSystem;
    private StateSystem _stateSystem;

    private CampInfoUI _campInfoUI;
    private GamePasuUI _gamePasuUI;
    private GameStateUI _gameStateUI;
    private SoldierInfoUI _soldierInfoUI;

    private bool _isGameOver = false;

    public bool isGameOver
    {
        get { return _isGameOver; }
    }

    public void Init()
    {
        _archievementSystem = new ArchievementSystem();
        _characterSystem = new CharacterSystem();
        _campSystem = new CampSystem();
        _energySystem = new EnergySystem();
        _gameEventSystem = new GameEventSystem();
        _stateSystem = new StateSystem();

        _campInfoUI = new CampInfoUI();
        _gamePasuUI = new GamePasuUI();
        _gameStateUI = new GameStateUI();
        _soldierInfoUI = new SoldierInfoUI();

        _archievementSystem.Init();
        _campSystem.Init();
        _characterSystem.Init();
        _energySystem.Init();
        _gameEventSystem.Init();
        _stateSystem.Init();

        _campInfoUI.Init();
        _gamePasuUI.Init();
        _gameStateUI.Init();
        _soldierInfoUI.Init();
    }

    public void Update()
    {
        _archievementSystem.Update();
        _campSystem.Update();
        _characterSystem.Update();
        _energySystem.Update();
        _gameEventSystem.Update();
        _stateSystem.Update();

        _campInfoUI.Update();
        _gamePasuUI.Update();
        _gameStateUI.Update();
        _soldierInfoUI.Update();
    }

    public void Release()
    {
        _archievementSystem.Release();
        _campSystem.Release();
        _characterSystem.Release();
        _energySystem.Release();
        _gameEventSystem.Release();
        _stateSystem.Release();

        _campInfoUI.Release();
        _gamePasuUI.Release();
        _gameStateUI.Release();
        _soldierInfoUI.Release();
    }
}
