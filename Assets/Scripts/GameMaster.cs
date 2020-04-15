using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private List<Level> levels;
    public static GameMaster gm;

    // Start is called before the first frame update
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
    }

    public void AddLevel(Level level)
    {
        levels.Add(level);
    }

    public void RemoveLevel(Level level)
    {
        levels.Remove(level);
    }

    public void UpdateLevels()
    {
        int startingLevelsCount = levels.Count;
        for(int i = 0; i < startingLevelsCount; i++)
        {
            levels[i].doStateAction();
        }
    }
}
