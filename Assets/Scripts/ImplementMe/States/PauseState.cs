using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : GameStateBase {
    
    public override void Update(Game game)
    {

        base.Update(game);
        ToState(game, RunningState);
    }

    public override void OnEnter(Game game)
    {
        base.OnEnter(game);
        Debug.Log("ENTERED PAUSE STATE");
    }

    public override void OnExit(Game game)
    {
        base.OnExit(game);
        Debug.Log("EXIT PAUSE STATE");
    }

}
