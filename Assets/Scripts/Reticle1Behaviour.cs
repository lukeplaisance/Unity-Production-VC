﻿using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class Reticle1Behaviour : MonoBehaviour
{
    private RaycastHit hit;
    private Ray ray;
    private bool fired;
    private bool active;
    public Image image;

    void Start ()
	{
	    ray = new Ray();
	    image.enabled = false;
        fired = false;
	    active = false;
	}

    void Update ()
    {
        if (Input.GetButton("P1Fire2"))
        {
            image.enabled = true;
            active = true;
        }

        if (Input.GetButton("P1Fire1") && !fired && active)
        {
            fired = true;
            ray = new Ray(gameObject.transform.position, gameObject.transform.forward);
            Debug.DrawRay(ray.origin, transform.forward * 999, Color.green, 5.0f);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider)
                {
                    Debug.Log("Ray hit " + hit.collider.name);
                }
                else
                {
                    Debug.Log("Attack Missed");
                }
            }
        }
    }
}