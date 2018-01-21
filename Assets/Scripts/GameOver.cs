using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour {
	private float timeLeft = 60;
	public Text text;
	public GameObject button;
	public GameObject player;
	public bool isGameOver=false;
	private float x, y, z;
	// Update is called once per frame
	void Update () {
		if (isGameOver) {
			GameObject crab = GameObject.Find("Crab01 (9)");
			if (crab!=null && crab.activeInHierarchy) {
				//crab.transform.LookAt (Vector3.zero);
			}
			player.transform.position = new Vector3(x,y,z);
			if ((button.activeSelf) && OVRInput.Get(OVRInput.RawButton.A)) {
				SceneManager.LoadScene(0);
			}
			return;
		}
		timeLeft -= Time.deltaTime;
		text.text = "Time:" + (int)timeLeft;
		x = player.transform.position.x;
		y = player.transform.position.y;
		z = player.transform.position.z;
		if (timeLeft <= 0) {
			button.SetActive(true);
			isGameOver = true;

		}
	}

}
