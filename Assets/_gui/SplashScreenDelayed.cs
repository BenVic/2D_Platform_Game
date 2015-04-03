using UnityEngine;
using System.Collections;

public class SplashScreenDelayed : MonoBehaviour 
{
	public float delayTime = 5f;

	void Start()
	{
		StartCoroutine ("Delay");
	}
		
	IEnumerator Delay()
	{
		yield return new WaitForSeconds (delayTime);
//		Application.LoadLevel(Constants.SCENE_LEVEL_1);
		Debug.Log ("Time's Up!");

	}

	void Update()
	{
		if (Input.anyKeyDown) 
		{
			Application.LoadLevel (0);
			Debug.Log ("A key or mouse click has been detected");
		}
	}
}
