using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface LevelState
{
    void execute(Level level);
}
