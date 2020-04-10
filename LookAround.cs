using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Transform playerBody;
    float xRotation = 0f;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Look();
    }

    void Look()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);


        playerBody.Rotate(Vector3.up * mouseX);
    }
}