using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextState : LevelState
{
    public void execute(Level level)
    {
        level.setState(new CurrentState());
        Spawner.spawner.spawnLevel(level);
    }
}
