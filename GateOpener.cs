using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public BoolData keyObj;

    void Update()
    {
        if (keyObj.value)
        {
            gameObject.setActive(false);
        }
    }
}