using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour 
{	
	[HideInInspector]
	public bool isFacingRight = false;
	public float maxSpeed = 4.5f;

	public void Flip()
	{
		isFacingRight = !isFacingRight;
		Vector3 enemyScale = this.transform.localScale;
		enemyScale.x = enemyScale.x * -1;
		this.transform.localScale = enemyScale;

	}
}
