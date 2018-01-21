using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneChange : MonoBehaviour {
	public GameObject b1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((b1.activeSelf) && OVRInput.Get(OVRInput.RawButton.A)) {
			SceneManager.LoadScene(0);
		}
		b1.SetActive(true);
	}
}
