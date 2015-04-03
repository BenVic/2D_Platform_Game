using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour 
{
	public int health = 6;
	public int coinsCollected = 0;

	public void CollectCoin(int coinValue)
	{
		this.coinsCollected = this.coinsCollected + coinValue;
	}

	public void TakeDamage(int damage, bool playHitReaction)
	{
			this.health = this.health - damage;
			Debug.Log("Player Health:" + this.health.ToString());

			if(playHitReaction == true) 
		{
			Debug.Log ("Hit reaction");
		}
	}
}

//	void PlayHitReaction()
//{
//	this.isImmune = true;
//	this.immunityTime = 0f;
//	this.gameObject.GetComponent<Animator>().SetTrigger("Damage");
//}



