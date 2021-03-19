using UnityEngine;

public class AmmoPoolBehaviour : MonoBehaviour
{
    public GameObject[] ammo;
    public int currentAmmoNum;

    void Update()
    {
        if (Input.GetKeyDown(keyCode.C))
        {
            ammo[currentAmmoNum].transform.position = transform.position;
            ammo[currentAmmoNum].transform.rotation = transform.rotation;
            ammo[currentAmmoNum].SetActive(true);
            if (currentAmmoNum < ammo.Length-1)
            {
                currentAmmoNum++;
            }
            else
            {
                currentAmmoNum = 0;
            }
        }
    }
}