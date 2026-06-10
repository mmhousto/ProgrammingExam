using UnityEngine;

[CreateAssetMenu(fileName = "Gun", menuName = "Scriptable Objects/Gun")]
public class Gun : ScriptableObject
{
    public int ammo;
    public int maxAmmo;
    public float fireRate;
    public string gunName;
}
