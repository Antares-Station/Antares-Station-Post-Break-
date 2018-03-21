using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBoss : MonoBehaviour {

    public float health;
    public bool isHit = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//make the fortress shoot from the bullet points
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player Bullet"))
        {
            isHit = true;
            health -= 1;
            isHit = false;
        }
    }
}
