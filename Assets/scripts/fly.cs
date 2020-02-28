
using UnityEngine;
using System.Collections;

public class fly : MonoBehaviour
{
    public float speed;

    float xRot = 0;
    float zRot = 0;
    float yRot = 0;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * ( speed));
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.up * (speed));
            
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody>().AddForce(-Vector3.right * ( speed));
            zRot++;
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * ( speed));
            zRot--;
        }
        transform.rotation = Quaternion.Euler(GetComponent<Rigidbody>().velocity.magnitude * yRot, 0.0f, GetComponent<Rigidbody>().velocity.magnitude * zRot);
    }
}