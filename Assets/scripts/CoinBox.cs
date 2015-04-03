using UnityEngine;
using System.Collections;

public class CoinBox : MonoBehaviour 
{
	public GameObject poppedStatePrefab;

	void OnTriggerEnter2D(Collider2D collider)
	{
		Vector3 heading = this.transform.position - collider.gameObject.transform.position;

		float distance = heading.magnitude;
		Vector3 direction = heading / distance;

		//if((direction.x < 0.1 && direction.x > -1.1) && (direction.y < 1.1 && direction.y > 0.4) && collider.tag == "Player")			
		if(collider.tag == "Player")
		{
			CoinPop();
		}
	}


	void CoinPop()
	{
		poppedStatePrefab.SetActive(true);
		this.gameObject.SetActive(false);
	}
}