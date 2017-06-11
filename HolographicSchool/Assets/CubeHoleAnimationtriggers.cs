using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHoleAnimationtriggers : MonoBehaviour
{
	Animator anim;
	public float boxAppearTimer = 12;


	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		boxAppearTimer -= Time.deltaTime;
		if (boxAppearTimer <= 0)
			anim.SetTrigger("BoxAppear");
	}
}
