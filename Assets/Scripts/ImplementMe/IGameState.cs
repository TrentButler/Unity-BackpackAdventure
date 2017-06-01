using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameState{

    void OnEnter(Game game);

    void OnExit(Game game);

    void Update(Game game);

    void ToState(Game game, IGameState gamestate);
	
}
