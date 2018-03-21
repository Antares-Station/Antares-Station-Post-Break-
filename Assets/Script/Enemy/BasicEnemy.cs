using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour {


    public GameObject bullet;
    public EnemyTrigger eTrigger;


    private void Start()
    {
        //bullet = 
    }

    private void Update()
    {
        if (eTrigger.seesTarget)
        {
            //for some reason i can't get my head around how to to shoot towards the player, i think i need sleep.
            //Instantiate(bullet, this.transform.position, Mathf.
        }
    }
}
