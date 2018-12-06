using UnityEngine;
using System.Collections;

public class move3 : MonoBehaviour
{

    private Vector3 pos1 = new Vector3(-76, 13, -170);
    private Vector3 pos2 = new Vector3(-76, 13, 41);
    public float speed = 0.01f;

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
        if (transform.position == pos2)
        {
            transform.Translate(Vector3.back, Space.World);
        }
    }
}