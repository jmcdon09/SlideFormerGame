using UnityEngine;
using System.Collections;

public class PlayerMoveVertical : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
	
		float speed = 0;
		float direction = 0;
		
		Sprite Background = GetComponent<Sprite>();
		if(Input.GetKey(KeyCode.DownArrow)) {
			speed = 1f;
			direction = -1;
		} else if(Input.GetKey(KeyCode.UpArrow)) {
			speed = 1f;
			direction = 1;
		}
			
		var pos = transform.position;
		pos.y += Time.deltaTime * speed * direction;
		transform.position = pos;
			
	}
}
