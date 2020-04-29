using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private List<Level> levels;
    public static GameMaster gm;

    void Awake()
    {
        gm = this;
        levels = new List<Level>();
        GameObject[] startingLevels = GameObject.FindGameObjectsWithTag("Level");
        for(int i = 0; i < startingLevels.Length; i++)
        {
            Level tempLevel = startingLevels[i].GetComponent<Level>();
            AddLevel(tempLevel);
        }

        //At start of game, CurrentLevel's state is NextState, so change it to CurrentState
        Level currLevel = GameObject.Find("CurrentLevel").GetComponent<Level>();
        currLevel.setState(new CurrentState());
    }

    public void AddLevel(Level level)
    {
        levels.Add(level);
    }

    public void RemoveLevel(Level level)
    {
        Debug.Log("total levels #: " + levels.Count + ", remove at index: " + levels.IndexOf(level));
        levels.Remove(level);
    }

    public void UpdateLevels()
    {
        /* Don't execute the newly added levels or else there will be an infitine loop on NewState.cs
         * So this only executes the levels that already existed.*/
        int startingLevelsCount = levels.Count;

        for (int i = startingLevelsCount - 1; i >= 0; --i)
        {
            levels[i].doStateAction();
        }
    }
}
