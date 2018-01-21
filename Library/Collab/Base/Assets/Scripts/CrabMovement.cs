using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CrabMovement : MonoBehaviour
{
	public Animator anim;
	public Transform target;
	public Transform mine;
	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	void Update()
	{	
		float val = 1;
		//mine.position = new Vector3(target.position.x,target.position.y-1f,target.position.z);
		//Transform targetPos = new Transform (v,target.rotation);
		//targetPos.rotation = target.rotation;
		transform.LookAt (target);
		transform.Translate(Vector3.forward*1*Time.deltaTime);
		if (mine.transform == target.transform)
			anim.SetLayerWeight (1, val);
	}
}