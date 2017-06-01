using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : GameStateBase {



    public override void Update(Game game)
    {
        base.Update(game);

    }

    public override void OnEnter(Game game)
    {
        base.OnEnter(game);
        Debug.Log("ENTERED IDLE STATE");
    }

    public override void OnExit(Game game)
    {
        base.OnExit(game);
        Debug.Log("EXIT IDLE STATE");
    }
}
