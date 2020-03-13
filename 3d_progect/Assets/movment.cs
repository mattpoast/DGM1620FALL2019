using UnityEngine;

public class movment : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 10f;
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.right) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("s"))
        {
            transform.position += transform.TransformDirection(Vector3.back) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey("space"))
        {
            transform.position += transform.TransformDirection(Vector3.up) * Time.deltaTime * jumpPower;
        }
            
    }
}
