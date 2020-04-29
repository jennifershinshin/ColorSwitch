using UnityEngine;

public class Level : MonoBehaviour
{
    private Transform smallCircle;

    public GameObject smallCirclePrefab;
    public LevelState levelState;

    public Level()
    {
        levelState = new NextState();
    }

    public Transform getSmallCircle()
    {
        return smallCircle;
    }

    public void setState(LevelState newState)
    {
        levelState = newState;
    }

    public LevelState getState()
    {
        return levelState;
    }

    public void doStateAction()
    {
        levelState.execute(this);
    }
}