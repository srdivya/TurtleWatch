using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionAccomplished : MonoBehaviour {

	public GameObject button;
	public GameObject player;
	void Update () 
	{
		if ((button.activeSelf) && OVRInput.Get(OVRInput.RawButton.A))
		{
			SceneManager.LoadScene(0);
		}
	}
	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.Equals (player)) 
		{
			button.SetActive(true);
			Rigidbody r = c.gameObject.GetComponent<Rigidbody>();
			r.constraints = RigidbodyConstraints.FreezePosition;
		}
	}
}
