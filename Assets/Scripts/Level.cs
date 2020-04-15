using UnityEngine;

public class Level : MonoBehaviour
{
    private Transform smallCircle;

    public GameObject smallCirclePrefab;
    public LevelState currentState;

    public Level()
    {
        currentState = new NextState();
    }

    public Transform getSmallCircle()
    {
        return smallCircle;
    }

    public void setState(LevelState newState)
    {
        currentState = newState;
    }

    public LevelState getState()
    {
        return currentState;
    }

    public void doStateAction()
    {
        currentState.execute(this);
        //could also change state here
        //if(currentState = Nextstate) change to current
    }
}