using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextState : LevelState
{
    public void execute(Level level)
    {
        //Debug.Log("Next State");
        level.setState(new CurrentState());
        //Debug.Log("changed to " + level.getState());
        Spawner.spawner.spawnLevel(level);
    }
}
