using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour 
{
	public int coinValue = 1;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag == "Player")
		{
			PlayerStats stats = collider.gameObject.GetComponent<PlayerStats>();
			stats.CollectCoin (this.coinValue);
			Destroy(this.gameObject);
		}
	}
}

