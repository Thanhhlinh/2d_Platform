using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEnemiesBaseState : CharacterBaseState
{
    protected MEnemiesManager _mEnemiesManager;

    public override void EnterState(CharactersManager charactersManager)
    {
        _mEnemiesManager = (MEnemiesManager)charactersManager;
    }
}