using UnityEngine;

public class DeadState : LevelState
{
    public void execute(Level level)
    {
        Debug.Log("Dead State");
        Object.Destroy(level.GetComponent<GameObject>());
    }
}
