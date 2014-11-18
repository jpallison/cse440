using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public float jumpHeight;
	public float multiplier;
	public bool isJumping = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				
				if (Input.GetKeyDown (KeyCode.Space)) {
						if (!isJumping) {
								rigidbody2D.AddForce (Vector2.up * jumpHeight);
								isJumping = true;
						}
				}

		}
	void OnCollisonEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Ground") {
			isJumping = false;		
		}
	}

}
