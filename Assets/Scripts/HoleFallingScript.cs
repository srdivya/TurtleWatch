using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoleFallingScript : MonoBehaviour {

	public static HoleFallingScript Instance{ set; get;}

	private bool isInTransition;
	private float transition;
	private bool isShowing;
	private float duration;
	public GameObject b1;
	public GameObject player;
	public int holeHeight;
	public GameOver g;
	private void Awake(){
		Instance = this;
	}

	public void Fade(bool showing, float duration){
		isShowing = showing;
		isInTransition = true;
		this.duration = duration;
		transition = (isShowing) ? 0 : 1;
	}

	private void Update(){
		
		if (player.transform.position.y <=holeHeight) {
			Fade (true, 1.25f);
			g.isGameOver = true;
		}
		if ((b1.activeSelf) && OVRInput.Get(OVRInput.RawButton.A)) {
			SceneManager.LoadScene(0);
		}

		if (!isInTransition) {
			//print ("not in trasnition");
			return;
		}

		transition += Time.deltaTime * (1 / duration);

		b1.SetActive(true);
	
		if (transition > 1 || transition < 0) {
			isInTransition = false;
		}
	}
}
