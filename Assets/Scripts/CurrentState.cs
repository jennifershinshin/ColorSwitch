using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentState : LevelState
{
    public void execute(Level level)
    {
        level.setState(new DeadState());
    }
}
