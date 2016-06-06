using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	private Rigidbody2D rb;
	private float drag;
	public Vector2 force;
	
	void Start() {
		
		rb = GetComponent<Rigidbody2D> ();
		rb.drag = drag;

		rb.AddForce (force,ForceMode2D.Impulse);
	}
	void FixedUpdate() {
		
		rb.drag = drag;
	}
}