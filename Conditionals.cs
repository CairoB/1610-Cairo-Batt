using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int a, b, c;
    public string password;
    public enum GameStates
    {
        Starting, Playing, Ending
    }
    void Start()
    {
        if (password != "OU812")
        {
            print("Correct");
        }
        else
        {

        }

    }
}