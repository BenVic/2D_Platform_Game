using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
			
		[HideInInspector]
		public bool
				isFacingRight = true;
		[HideInInspector]
		public bool
				isJumping = false;
		[HideInInspector]
		public bool
				isGrounded = false;
		[HideInInspector]
		public bool
				isDoubleJumping = false;
		public float jumpForce = 650.0f;
		public float maxSpeed = 7.0f;
		public PhysicsMaterial2D jumpMaterial;
		public Transform groundCheck;
		public LayerMask groundLayers;
		public float groundCheckRadius = 0.2f;
		private Animator anim;

		void Awake ()
		{
				anim = this.GetComponent<Animator> ();
		}

		void Update ()
		{
				if (Input.GetButtonDown ("Jump")) {
						if (isGrounded == true) {
								this.rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0);
								this.rigidbody2D.AddForce (new Vector2 (0, jumpForce));
								this.anim.SetTrigger ("Jump");
						} else if (isDoubleJumping == false) {
								isDoubleJumping = true;
								Debug.Log ("Jump pressed while not grounded");
						}

				}

		}

		void FixedUpdate ()
		{
				isGrounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, groundLayers);

				PhysicsMaterial2D material = this.gameObject.GetComponent<CircleCollider2D> ().sharedMaterial;

				if (isGrounded == true) {
						isDoubleJumping = false;
				}
				if (isGrounded == true && material == this.jumpMaterial) {
						CircleCollider2D collision = this.gameObject.GetComponent<CircleCollider2D> ();
						collision.sharedMaterial = null;
						collision.enabled = false;
						collision.enabled = true;
				} else if (isGrounded == false && this.gameObject.GetComponent<CircleCollider2D> ().sharedMaterial == null) {
						CircleCollider2D collision = this.gameObject.GetComponent<CircleCollider2D> ();
						collision.sharedMaterial = this.jumpMaterial;
						collision.enabled = false;
						collision.enabled = true;
				}
				try {
						float move = Input.GetAxis ("Horizontal");
						//maxSpeed = 3.0f;
						this.rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
						this.anim.SetFloat ("Speed", Mathf.Abs (move));
						if ((move > 0.0f && isFacingRight == false) || (move < 0.0f && isFacingRight == true)) {
								Flip ();
						}
				} catch (UnityException error) {
						Debug.LogError (error.ToString ());
				}
		}
		
		void Flip ()
		{
				isFacingRight = !isFacingRight;
				Vector3 playerScale = transform.localScale;
				playerScale.x = playerScale.x * -1;
				transform.localScale = playerScale;
		}
}  

