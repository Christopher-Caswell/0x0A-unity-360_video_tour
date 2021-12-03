using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingAround : MonoBehaviour
{

void Start()
{

}

void Update()
{
    if (Input.GetMouseButton(0))
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * mouseX);
        transform.Rotate(Vector3.right * mouseY);
    }
}
}
