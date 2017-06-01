using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public IGameState Current;
    protected static IGameState IdleState = new IdleState();
    private GameStateBase FSM;


    void Start()
    {
        FSM = new GameStateBase();
        Current = FSM.Init;
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Current.ToState(this, IdleState);
        }
        Current.Update(this);

    }

}
