using UnityEngine;
public class Movement : MonoBehaviour
{
    public float movmentSpeed;
    public float jumpPower;
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

        if (Input.GetKey("w"))
        {
            transform.position += Vector3.up * Time.deltaTime * jumpPower;
        }

        if (Input.GetKey("s"))
        {
            transform.position += Vector3.down * Time.deltaTime * movmentSpeed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale += Vector3.down;
        }

        if (Input.GetKey("f"))
        {
            transform.localScale -= Vector3.down;
        }
    }
}
