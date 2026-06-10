using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class LoadGun : MonoBehaviour
{

    public Gun gun;
    public TextMeshProUGUI ammo;
    public TextMeshProUGUI gunName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammo.text = $"{gun.ammo}/{gun.maxAmmo}";
        gunName.text = gun.gunName;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gun.ammo--;
            ammo.text = $"{gun.ammo}/{gun.maxAmmo}";
        }
    }
}
