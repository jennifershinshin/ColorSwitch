using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextState : LevelState
{
    public void execute(Level level)
    {
        Debug.Log("Next State");
        level.setState(new CurrentState());
        Spawner.spawner.spawnLevel(level);
    }
}
