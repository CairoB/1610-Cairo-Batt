using UnityEngine;

public class CameraLookAt : Monobehaviour
{
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}