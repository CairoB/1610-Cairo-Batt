using UnityEngine;

public class AwakeAndStart : MonoBehaviour
{
    void Awake()
    // called before script is enabled
    {
        Debug.Log("Awake called.");
    }

    void Start()
    // called when script is enabled
    {
        Debug.Log("Start called.");
    }

    // both functions can only execute once!
}