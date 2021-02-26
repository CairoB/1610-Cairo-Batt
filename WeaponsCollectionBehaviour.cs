using UnityEngine;

public class WeaponsCollectionBehaviour : MonoBehaviour
{
    public Weapon weaponObj;
    public WeaponCollection weaponCollectionObj;

    private void Start()
    {
        foreach (var weapon in weaponCollectionObj.weaponsList)
        {
            if (weapon == weaponObj)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        weaponCollectionObj.weaponsList.Add(weaponObj);
        gameObject.SetActive(false);
    }
}