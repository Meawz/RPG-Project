using UnityEngine;

public class Spin : MonoBehaviour
{
    void Update ()
    {
        transform.Rotate(0f, 100f * Time.deltaTime, 0f, Space.Self);
    }
}
