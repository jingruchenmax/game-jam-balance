using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        if(this.GetComponent<Rigidbody>()!=null)
            rigidbody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1),ForceMode.Impulse);
            //rigidbody.AddTorque(new Vector3(1, 0, 0),ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //rigidbody.AddTorque(new Vector3(-1, 0, 0), ForceMode.Impulse);
            rigidbody.AddForce(new Vector3(0, 0, -1), ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddTorque(new Vector3(0, 0.5f, 0), ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddTorque(new Vector3(0, -0.5f, 0), ForceMode.Impulse);
        }
    }
}
