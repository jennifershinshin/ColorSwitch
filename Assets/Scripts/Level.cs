using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private LevelState currentState;
    private Transform smallCircle;

    public static Level level;
    public GameObject smallCirclePrefab;

    public Level()
    {
        currentState = new NextState();
    }

    void Awake()
    {
        level = this;
        //currentState = new NextState();
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
        Debug.Log(currentState);
        currentState.execute(this);
    }
}