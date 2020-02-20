using UnityEngine;
public class Movement : MonoBehaviour
{
    public float movmentSpeed;
    void Update()
    {
        if (Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * movmentSpeed;
        }
    }
}
