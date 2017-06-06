using UnityEngine;

public class AirtapCommand : MonoBehaviour
{
	// Called by GazeGestureManager when the user performs a Select gesture
	void OnSelect()
	{
			gameObject.SetActive(false);
	}
}