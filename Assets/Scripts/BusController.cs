using System;
using UnityEngine;

public class BusController : MonoBehaviour
{
    
    [SerializeField] float speed;

    void FixedUpdate() {
        transform.Translate(speed *  Time.deltaTime * Vector3.forward);
    }
    
}
