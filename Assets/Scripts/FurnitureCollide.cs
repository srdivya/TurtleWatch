using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FurnitureCollide : MonoBehaviour {
	public GameObject button;
	public GameObject player;
	public GameOver g;
	private bool isGameOver=false;
	private float x, y, z;

	public void Update(){
		if (isGameOver) {
			player.transform.position = new Vector3(x,y,z);
		}
		if ((button.activeSelf) && OVRInput.Get (OVRInput.RawButton.A)) {
			SceneManager.LoadScene (0);
		}
	}
	public void OnCollisionEnter(Collision c){
		if (c.gameObject.name.Contains("Player") && !isGameOver)
		{
			button.SetActive(true);
			isGameOver = true;
			g.isGameOver = true;
			x = c.gameObject.transform.position.x;
			y = c.gameObject.transform.position.y;
			z = c.gameObject.transform.position.z;

		}
	}
}
