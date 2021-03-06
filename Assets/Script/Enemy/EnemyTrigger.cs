﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {

    public GameObject target;
    public bool seesTarget;
    public float targetAngle;

    private void Update()
    {
        target = GameObject.FindGameObjectWithTag("player");
        targetAngle = Mathf.Atan2(target.transform.position.y, target.transform.position.x) * Mathf.Rad2Deg;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!seesTarget)
        {
            target = collision.gameObject;
            seesTarget = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == target)
        {
            seesTarget = false;
        }
    }


}
