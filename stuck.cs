using UnityEngine;
using System.Collections;

public class stuck : MonoBehaviour {

	private Rigidbody2D rb2d;

	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.CompareTag ("pick")) {
			DistanceJoint2D dj2d;
			dj2d = gameObject.AddComponent <DistanceJoint2D> ();
			dj2d.connectedBody = other.gameObject.GetComponent<Rigidbody2D> ();
		
		}
		if (other.gameObject.CompareTag("walls")) {
			//rb2d.velocity = new Vector2 (0, 0);
			FixedJoint2D fj2d;
			fj2d = gameObject.AddComponent<FixedJoint2D> ();

		}
		
	}
		
}
