﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerBehaviour : MonoBehaviour
{
    public GameObject player;
    public bool isFirstPerson;
    public GameObject camera;
    CameraControllerBehaviour cc;

    // Use this for initialization
    void Start ()
    {
        cc = GetComponent<CameraControllerBehaviour>();
	}

    private void Update()
    {
        camera.transform.parent = player.transform;
        if (Input.GetButton("Fire2"))
        {
            isFirstPerson = true;
            camera.transform.position = Vector3.Lerp(camera.transform.position, player.transform.position, Time.deltaTime * 10);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
    }
}