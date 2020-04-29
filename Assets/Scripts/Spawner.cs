using UnityEngine;

public class Spawner : MonoBehaviour
{
    private GameObject Level;
    private GameObject ColorChanger;

    public static Spawner spawner;

    public GameObject levelPrefab;
    public GameObject ColorChangerPrefab;

    public Vector3 offset;// = new Vector3(0,6.5f,0);
    public Vector3 ColorChangerOffset;// = new Vector3(0,2f,0);

    /*
     * Instantiating the game
     */
    private void Awake()
    {
        spawner = this;
    }

    public void spawnLevel(Level level)
    {
        GameObject go = Instantiate(levelPrefab, level.GetComponent<Transform>().position + offset, Quaternion.identity) as GameObject;
        Level newLevel = go.GetComponent<Level>();
        GameMaster.gm.AddLevel(newLevel);

        ColorChanger = GameObject.FindWithTag("ColorChanger");
        Destroy(ColorChanger);
        Instantiate(ColorChangerPrefab, level.GetComponent<Transform>().position + ColorChangerOffset, Quaternion.identity);
    }
}
