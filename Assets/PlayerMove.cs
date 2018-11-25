using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;
    private Rigidbody2D rigid2D;


	// Use this for initialization
	void Start () {
        rigid2D = GetComponent<Rigidbody2D>();
		//Move();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rigid2D.AddForce(movement * speed);

       // Move();
	}

	public void Move() {
		//transform.Translate(Vector2.right);
	}
} 
