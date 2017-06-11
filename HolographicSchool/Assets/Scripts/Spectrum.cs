using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spectrum : MonoBehaviour
{

	public GameObject prefab;
	public int numberOfObjects = 20;
	public float radius = 5f;
	public GameObject[] cubes;

	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < numberOfObjects; i++)
		{
			float angle = i * Mathf.PI * 2 / numberOfObjects;
			Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
			GameObject tmp = Instantiate(prefab, pos, Quaternion.identity);
			tmp.transform.parent = transform;
		}

		cubes = GameObject.FindGameObjectsWithTag("Cube");
		transform.Translate(new Vector3(1f,2.5f,0.25f));
		transform.Rotate(new Vector3(90, 0, 0));
	}


	void Update()
	{
		float[] spectrum = AudioListener.GetSpectrumData(1024, 0, FFTWindow.Hamming);
		for (int i = 0; i < numberOfObjects; i++)
		{
			Vector3 previousScale = cubes[i].transform.localScale;
			previousScale.z = Mathf.Lerp(previousScale.z, spectrum[i] * 5, Time.deltaTime * 30);
			cubes[i].transform.localScale = previousScale;
		}
	}
}
