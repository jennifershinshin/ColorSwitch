using UnityEngine;

public class DeadState : LevelState
{
    public void execute(Level level)
    {
        //Debug.Log("Dead State");
        GameMaster.gm.RemoveLevel(level);
        GameObject.Destroy(level.gameObject);
    }
}
