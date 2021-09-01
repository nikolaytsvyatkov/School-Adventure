using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int whichWeaponselected;
    private GameObject weapon;

    void Start()
    {
        whichWeaponselected = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchWeapon();
        }
    }

    private void SwitchWeapon()
    {
        switch (whichWeaponselected)
        {
            case 1:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }
                weapon = Instantiate(Resources.Load("Prefabs/Shotgun_"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(0.2f, 0.15f, 0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = new Vector4(0.09f, 0.09f, 0f);
                whichWeaponselected += 1;
                break;

            case 2:
                if (weapon != null)
                {
                    Destroy(weapon.gameObject);
                }
                weapon = Instantiate(Resources.Load("Prefabs/Gun_"), transform.position, transform.rotation) as GameObject;
                weapon.transform.SetParent(gameObject.transform);
                weapon.transform.localPosition = new Vector3(0.2f, 0.18f, 0f);
                weapon.GetComponent<Renderer>().sortingOrder = gameObject.GetComponent<Renderer>().sortingOrder + 1;
                weapon.transform.localScale = new Vector4(0.04f, 0.04f, 0f);
                whichWeaponselected += 1;
                break;
        }

        if (whichWeaponselected > 2)
        {
            whichWeaponselected = 1;
        }
    }
}