using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour {


    public GameObject bullet;
    public EnemyTrigger trigger;


    private void Start()
    {
        trigger = gameObject.GetComponentInChildren<EnemyTrigger>();
    }

    private void Update()
    {

        if (trigger.seesTarget)
        {
            //for some reason i can't get my head around how to to shoot towards the player, i think i need sleep.
            Instantiate(bullet, this.transform.position, Quaternion.AngleAxis(trigger.targetAngle, Vector3.forward));
        }
    }
}
