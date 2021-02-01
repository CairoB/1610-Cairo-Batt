using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        // This line is here to tell me the x position of my object

        /* multi-line comment
         * another line
         * */
        
        Debug.Log(transform.position.x);

        /*
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
        */
    }
}
