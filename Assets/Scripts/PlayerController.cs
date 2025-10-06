using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] float speed;
    [SerializeField] float turnSpeed;
    
    void FixedUpdate() {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");
        transform.Translate(speed *  Time.deltaTime * verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }
    
}
