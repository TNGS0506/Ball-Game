using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .5f, ground);
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKeyDown("space") && IsGrounded())
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5.5f, 0);
        }
    }

}
