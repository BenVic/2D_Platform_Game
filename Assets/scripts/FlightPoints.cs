//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
		public class FlightPoints:MonoBehaviour
		{
				public GameObject waypointA;
				public GameObject waypointB;
				public float speed = 1;
				public bool shouldChangeFacing = false;
				public bool directionAB = true;

				void FixedUpdate ()
				{
			Debug.Log ("Fly Update");
						if ((this.transform.position == waypointA.transform.position && directionAB == false) || 
			    (this.transform.position == waypointA.transform.position && directionAB == true)) {
								directionAB = !directionAB;
			
								if (this.shouldChangeFacing == true) {
										this.gameObject.GetComponent<EnemyController> ().Flip ();
					Debug.Log ("Fly Flipped");
								}

						}

						if (directionAB == true) {
								this.transform.position = Vector3.MoveTowards (this.transform.position, waypointB.transform.position, speed * Time.fixedDeltaTime);
				Debug.Log ("Fly PathB");
						} else {
								this.transform.position = Vector3.MoveTowards (this.transform.position, waypointA.transform.position, speed * Time.fixedDeltaTime);
				Debug.Log ("Fly PathA");}
				}

		}
}

