using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextState : LevelState
{
    public void execute(Level level)
    {
        Debug.Log("Next State");
        //state = current state
        //(I SHOULD PROBABLY CREATE THE NEW LEVEL IN SPAWNER AND MAYBE COLOR CHANGER)
        //(OR NOT?? IDK)
        //create new level (which will be the "next state")
        //create a colorChanger right above this level

        Spawner.spawner.spawnLevel(level);
    }
}
