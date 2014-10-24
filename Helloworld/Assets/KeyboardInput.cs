using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour {
	public float moveSpeed =.05f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tempPosition;
		If (input.getaxis (“Horizontal”) > 0)){
			tempPosition.x += moveSpeed;
		}
		If (input.getaxis (“Horizontal”) <0)){
			tempPosition.x -= moveSpeed;
		}
		If (input.getaxis (“Vertical”) > 0)){
			tempPosition.y += moveSpeed;
		}
		If (input.getaxis (“Vertical”) < 0)){
			tempPosition.y -= moveSpeed;
		}
		Transform.position = tempPosition;

	}
}
