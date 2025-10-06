using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] float speed;
    [SerializeField] float turnSpeed;
    [SerializeField] Camera driverCamera;
    [SerializeField] Camera backCamera;
    [SerializeField] KeyCode playerCamSwitchKey;
    [SerializeField] string playerId;
    List<Camera> cameras = new List<Camera>();
    int activeCamIndex = 0;
    
    void Start() {
        cameras.Add(backCamera);
        cameras.Add(driverCamera);
        cameras[0].enabled = true;
    }

    void FixedUpdate() {
        var horizontalInput = Input.GetAxis("Horizontal" + playerId);
        var verticalInput = Input.GetAxis("Vertical" + playerId);
        transform.Translate(speed *  Time.deltaTime * verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }

    void Update() {
        var cameraSwitch = Input.GetKeyUp(playerCamSwitchKey);
        if (cameraSwitch) {
            cameras[activeCamIndex].enabled = false;
            activeCamIndex = (activeCamIndex + 1) % cameras.Count;
            cameras[activeCamIndex].enabled = true;    
        }
    }
}
