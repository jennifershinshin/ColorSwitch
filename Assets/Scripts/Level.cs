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

    public static Level Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        //do i have to create its child objects
        setColorChanger();
        setSmallCircle();
    }
    private void Start()
    {
        
    }
    void setColorChanger()
    {
        if(GameObject.FindWithTag("ColorChanger"))
        {
            colorChanger = GameObject.FindWithTag("ColorChanger").GetComponent<Transform>();
        }
        else
        {
            GameObject colorChangerGO = Instantiate(colorChangerPrefab) as GameObject;
            colorChanger = colorChangerGO.GetComponent<Transform>();
        }
    }

    public Transform getColorChanger()
    {
        return colorChanger;
    }

    void setSmallCircle()
    {
        if (GameObject.FindWithTag("SmallCircle"))
        {
            smallCircle = GameObject.FindWithTag("SmallCircle").GetComponent<Transform>();
        }
        else
        {
            GameObject smallCircleGO = Instantiate(smallCirclePrefab) as GameObject;
            smallCircle = smallCircleGO.GetComponent<Transform>();
        }
    }

    public Transform getSmallCircle()
    {
        return smallCircle;
    }
}