using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleCars : MonoBehaviour {
	public Transform carForward;
	public Transform spawn1;


	public GameObject carBackward;
	public Transform spawn2;
	void Start()
	{
		InvokeRepeating("LaunchCars", 2.0f, 0.3f);
	}

	void LaunchCars()
	{
		Instantiate(carForward, spawn1.position, Quaternion.identity);
		//instance.velocity = Random.insideUnitSphere * 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
