using UnityEngine;
using System.Collections;



public class NewBehaviourScript : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	// Use this for initializatio
	void Start () {
		SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)){
				if (SpriteRenderer.sprite == sprite1) {
						SpriteRenderer.sprite = sprite2;
				}
		else{
			SpriteRenderer.sprite = sprite1;
		}
	}

	}
}
