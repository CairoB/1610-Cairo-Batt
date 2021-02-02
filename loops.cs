using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;

    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }
}

public class DoWhileLoop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");
        }
        while (shouldContinue == true);
    }
}

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;

    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}