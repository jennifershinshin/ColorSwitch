using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    private List<Level> levels;

    // Start is called before the first frame update
    void Awake()
    {
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
        for(int i = 0; i < levels.Count; i++)
        {
            levels[i].doStateAction();
        }
    }
}
