using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{

	public float timerForBoxAppear;
	public bool startTimer = false;
	public GameObject prefab;
	public Vector3 pos;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (startTimer)
		{
			timerForBoxAppear -= Time.deltaTime;
			if (timerForBoxAppear <= 0)
				Action();
		}
	}


	void Action()
	{
		Instantiate(prefab, pos, Quaternion.identity);
		startTimer = false;
	}
}
