using UnityEngine;
using System.Collections;

public class EnemySlime : EnemyController
{
		void FixedUpdate ()
		{
				if (this.isFacingRight == true) {
						this.GetComponent<Rigidbody2D>().velocity = new Vector2 (maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
				} else {
						this.GetComponent<Rigidbody2D>().velocity = new Vector2 (maxSpeed * -1, this.GetComponent<Rigidbody2D>().velocity.y);
				}
		}

		void OnTriggerEnter2D (Collider2D collider)
		{
				if (collider.tag == "Wall") {
						Flip ();
				} else if (collider.tag == "Enemy") {
						EnemyController controller = collider.gameObject.GetComponent<EnemyController> ();
						controller.Flip ();
						Flip ();
				}
		}
}


