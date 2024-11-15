using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public enum GameState
{
    Menu,
    Gameplay,
    Victory,
    GameOver
}

public class GameManager : Singleton<GameManager>
{
    public static event System.Action<GameState> OnStateChange;


    [SerializeField] private GameState m_initialState;


    public static GameState CurrentState { get; private set; } = (GameState)(-1);


    protected override bool Persistent => false;


    private void Start()
    {
        SwitchState(m_initialState);
    }
    // if (health == 0) 
    // {
    //      GameManager.SwitchState(GameState.GameOver);
    // }
    public static void SwitchState(GameState state)
    {
        if (state == CurrentState) return;

        CurrentState = state;
        OnStateChange?.Invoke(state);
    }
}

