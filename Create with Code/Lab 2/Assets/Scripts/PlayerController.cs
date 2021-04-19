using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{

    public Vector3 north;
    public Vector3 east;
    public Vector3 south;
    public Vector3 west;
    public float speed;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        north.Set(0,0,1);
        east.Set(1,0,0);
        south.Set(0,0,-1);
        west.Set(-1,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        direction.Set(0,0,0);
        if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -1;
        }
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.y < 0)
        {
            transform.Translate(Vector3.up);
        }
    }
}
