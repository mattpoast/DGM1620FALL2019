using UnityEngine;
public class FireWeapon : MonoBehaviour
{
    public ApplyForce ammo;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ammo,transform.position, Quaternion.identity);
            
            
        }
    }
}
