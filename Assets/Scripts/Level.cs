using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private static Level _instance;
    private Transform colorChanger;
    private Transform smallCircle;

    public GameObject smallCirclePrefab;
    public GameObject colorChangerPrefab;

    Vector3 newLevelPosition = new Vector3(0, 3, 0);

    public static Level Instance { get { return _instance; } }

    private void Awake()
    {
         if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            Destroy(GameObject.FindWithTag("ColorChanger").GetComponent<Transform>());
            Destroy(GameObject.FindWithTag("SmallCircle").GetComponent<Transform>());
        }
        else
        {
            _instance = this;
        }
        //Should I instantiate level. or doesnt it already do it in Spawner. maybe move it to here as well..
        //maybe that wouldnt make sense bc if its instantiated, awake runs.
        //I may not need these bc i think if i instantiate level, the children will also be created
        createColorChanger();
        createSmallCircle();
    }
    private void Start()
    {
        
    }
    void createColorChanger()
    {
        if(GameObject.FindWithTag("ColorChanger"))
        {
            colorChanger = GameObject.FindWithTag("ColorChanger").GetComponent<Transform>();
        }
        else
        {
            GameObject colorChangerGO = Instantiate(colorChangerPrefab, this.transform.position + newLevelPosition, Quaternion.identity) as GameObject;
            colorChanger = colorChangerGO.GetComponent<Transform>();
        }
    }

    public Transform getColorChanger()
    {
        return colorChanger;
    }

    void createSmallCircle()
    {
        if (GameObject.FindWithTag("SmallCircle"))
        {
            smallCircle = GameObject.FindWithTag("SmallCircle").GetComponent<Transform>();
        }
        else
        {
            GameObject smallCircleGO = Instantiate(smallCirclePrefab, this.transform.position + newLevelPosition, Quaternion.identity) as GameObject;
            smallCircle = smallCircleGO.GetComponent<Transform>();
        }
    }

    public Transform getSmallCircle()
    {
        return smallCircle;
    }
}