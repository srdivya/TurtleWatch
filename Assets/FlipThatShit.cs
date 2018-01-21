using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipThatShit : MonoBehaviour {
	public float maxUpDown = 10.0f;
	private string direction = "up";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (transform.rotation.eulerAngles.x) <= 30.0f || direction.Equals ("up")) {
			transform.Rotate(new Vector3(3.0f, 1.0f, 2.0f));
				if (Mathf.Abs (transform.rotation.eulerAngles.x) <= 30.0f) {
				direction = "down";
			}
		} else {
			transform.Rotate(new Vector3(-5.0f, 0.0f, 0.0f));
			if (Mathf.Abs (transform.rotation.eulerAngles.x) <= 0.0f) {
				direction = "up";
			}
		}
	}
}
