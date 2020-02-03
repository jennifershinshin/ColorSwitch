using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : LevelState
{
    public void execute(Level level)
    {
        Debug.Log("Current State");
        level.setState(new DeadState());
    }
}
