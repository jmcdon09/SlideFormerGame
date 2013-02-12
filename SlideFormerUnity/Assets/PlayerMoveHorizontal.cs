using UnityEngine;
using System.Collections;

public class PlayerMoveHorizontal : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	
		float speed = 0;
		float direction = 0;	
	
		Sprite Background = GetComponent<Sprite>();
		if(Input.GetKey(KeyCode.LeftArrow)) {
			speed = 1f;
			direction = -1;
		} else if(Input.GetKey(KeyCode.RightArrow)) {
			speed = 1f;
			direction = 1;
		}
			
		var pos = transform.position;
		pos.x += Time.deltaTime * speed * direction;
		transform.position = pos;
		
		print("Current x position: " + x);
	}
}
