using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // rigidbodyのx軸（横）とz軸（奥）に力を加える
        rigidbody.AddForce(x*speed, 0, z*speed);
    }
}
