using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface LevelState
{
    public void execute(Level level);
}
