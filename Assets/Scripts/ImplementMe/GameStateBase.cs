using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBase : IGameState
{

    static protected IGameState PauseState = new PauseState();
    static protected IGameState RunningState = new RunningState();

    public IGameState Init
    {
        get { return PauseState; }
    }

    public virtual void OnEnter(Game game)
    {
        return;
    }

    public virtual void OnExit(Game game)
    {
        return;
    }

    public virtual void ToState(Game game, IGameState gamestate)
    {
        game.Current.OnExit(game);
        game.Current = gamestate;
        game.Current.OnEnter(game);
    }

    public virtual void Update(Game game)
    {
    }
}
