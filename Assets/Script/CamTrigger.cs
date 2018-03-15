using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTrigger : MonoBehaviour {

    public camerafollow cam;
    public GameObject target;


    public int ID;

    private void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<camerafollow>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            cam.target = target.transform;
        }
    }
}
