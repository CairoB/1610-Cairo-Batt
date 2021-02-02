using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time: " + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update time: " + Time.deltaTime);
    }
}