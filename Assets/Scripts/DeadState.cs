using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadState : LevelState
{
    public void execute(Level level)
    {
        Debug.Log("Dead State");
        //destroy this
    }
}
