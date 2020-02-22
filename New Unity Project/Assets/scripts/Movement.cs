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

        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * Time.deltaTime * movmentSpeed;
        }
    }
}
