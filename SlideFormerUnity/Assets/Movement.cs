using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 0.1f;
	public float direction = -1;
	
	// Update is called once per frame
	void Update () {
	
		Sprite Background = GetComponent<Sprite>();
		
		var pos = transform.position;
		pos.x += Time.deltaTime * speed * direction;
		transform.position = pos;
		
		
	}
}
