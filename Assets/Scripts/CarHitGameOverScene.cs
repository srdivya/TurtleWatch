using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarHitGameOverScene : MonoBehaviour {

    public GameObject player;
    public GameObject button;
	public GameObject carCrashAudio;
	public GameOver g;
	private bool isGameOver=false;
	private float x, y, z;
	// Update is called once per frame
	private void Update () {
		if (isGameOver) {
			player.transform.position = new Vector3(x,y,z);
		}
        if ((button.activeSelf) && OVRInput.Get(OVRInput.RawButton.A))
        {
            SceneManager.LoadScene(0);
        }
    }

    void OnCollisionEnter(Collision c)
    {
		if (c.gameObject.name.Contains("Player"))
		{
			button.SetActive(true);
			isGameOver = true;
			g.isGameOver = true;
			x = player.transform.position.x;
			y = player.transform.position.y;
			z = player.transform.position.z;
			carCrashAudio.GetComponent<AudioSource> ().Play();
		}
    }
}
