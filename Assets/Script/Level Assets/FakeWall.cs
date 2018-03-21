using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeWall : MonoBehaviour {

    Animator anim;

    public bool isHit = false;
    public int health = 5;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            isHit = true;
            health -= 1;
            isHit = false;
        }
    }
}
