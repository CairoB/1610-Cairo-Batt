using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int myInt = 5;

    void Start()
    {
        MultiplyByTwo(myInt);
        Degug.Log(myInt);
    }

    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }
}