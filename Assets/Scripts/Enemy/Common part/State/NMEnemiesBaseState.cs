using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NMEnemiesBaseState : CharacterBaseState
{
    protected NMEnemiesManager _nmEnemiesManager;

    public override void EnterState(CharactersManager charactersManager)
    {
        _nmEnemiesManager = (NMEnemiesManager)charactersManager;
    }
}
