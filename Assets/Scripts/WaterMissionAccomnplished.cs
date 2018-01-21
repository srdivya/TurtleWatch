using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WaterMissionAccomnplished : MonoBehaviour {

	public static WaterMissionAccomnplished Instance{ set; get;}

	private bool isInTransition;
	private float transition;
	private bool isShowing;
	private float duration;
	public GameObject b1;
	public GameObject player;
	public GameOver g;
	public int waterZ;
	private void Awake(){
		Instance = this;
	}

	private void Update(){

		if (player.transform.position.z >=waterZ) {
			GameObject crab = GameObject.Find("Crab01 (9)");
			if (crab!=null && crab.activeInHierarchy) {
				crab.transform.LookAt (Vector3.zero);
			}
			isInTransition = true;
			g.isGameOver = true;
		}
		if ((b1.activeSelf) && OVRInput.Get(OVRInput.RawButton.A)) {
			SceneManager.LoadScene(0);
		}

		if (!isInTransition) {
			return;
		}

		b1.SetActive(true);

	}
}
