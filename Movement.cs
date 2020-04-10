using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public CharacterController controller1;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 Move = transform.right * x + transform.forward * z;
        controller1.Move(Move * Speed * Time.deltaTime);
    }
}
