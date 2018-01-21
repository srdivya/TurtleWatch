using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrabMovement : MonoBehaviour
{
	public Animator anim;
	public Transform target;
	public Transform mine;
	public GameObject pincerAudio;
	public GameObject player;
	public GameObject button;
	public GameOver g;
	private bool isGameOver=false;
	private float x, y, z;
	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	void Update()
	{	
		if ((button.activeSelf) && OVRInput.Get(OVRInput.RawButton.A))
		{
			SceneManager.LoadScene(0);
		}
		if (isGameOver) {
			player.transform.position = new Vector3(x,y,z);
			return;
		}
		float val = 1;
		var distanceToPlane = Vector3.Dot(transform.up, target.position - transform.position);
		var planePoint = target.position - transform.up * distanceToPlane;
		transform.LookAt(planePoint, transform.up);
		transform.Translate(Vector3.forward*1*Time.deltaTime);

	}
	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.Equals (player)) 
		{
			button.SetActive(true);
			isGameOver = true;
			g.isGameOver = true;
			x = player.transform.position.x;
			y = player.transform.position.y;
			z = player.transform.position.z;
			anim.SetLayerWeight (1, 1f);
			pincerAudio.GetComponent<AudioSource> ().Play ();
		} 
		else 
		{
			anim.SetLayerWeight (0, 1f);
			pincerAudio.GetComponent<AudioSource> ().Stop();
		}
			
	}
}