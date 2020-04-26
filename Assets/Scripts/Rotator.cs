using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);     //rotate on (x,y,z) = (0, 0, z)
    }
}
