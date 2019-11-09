using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject Level;
    
    public Transform camera;
    public Transform player;
    public GameObject levelPrefab;


    private void Awake()
    {
        Level = GameObject.FindWithTag("Level");

        //find Level(contains smallCircle and colorChanger)
        // find colorChanger. get position of colorChanger.
        //maybe only have one colorChanger in world
    }

    // Update is called once per frame
    void Update()
    {
        //TODO: check for Level. level must always be available except for when its not
        if(!doesLevelExist())
        {
            Instantiate(levelPrefab, player.position, Quaternion.identity);
            Level = GameObject.FindWithTag("Level");
        }
    }

    bool doesLevelExist()
    {
        if(Level == null)
        {
            return false;
        }
        return true;
    }
}
