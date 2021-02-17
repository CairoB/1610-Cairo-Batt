using UnityEngine;

public class BoostBehaviour : MonoBehaviour
{
    public bool haveKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (haveKey)
        {
            print(true);
        }
    }
}