using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Level;
    public Transform camera;
    public Transform player;

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
        if(!getColorChanger())
        {
            Debug.Log("nonono");
            spawnLevel();
        }
    }

    void spawnLevel()
    {
        //need position maybe before it gets destroyed. maybe at level's awake
          Instantiate(Level, player.position, Quaternion.identity);
    }

    Transform getColorChanger()
    {
        return Level.GetComponent<Level>().getColorChanger();
    }
    Transform getSmallCircle ()
    {
        return Level.GetComponent<Level>().getSmallCircle();
    }
}
