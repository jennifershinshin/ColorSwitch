using UnityEngine;

public class DeadState : LevelState
{
    public void execute(Level level)
    {
        GameMaster.gm.RemoveLevel(level);
        GameObject.Destroy(level.gameObject);
    }
}
