using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Move();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
	}

	public void Move() {
		transform.Translate(Vector2.right);
	}
} 
