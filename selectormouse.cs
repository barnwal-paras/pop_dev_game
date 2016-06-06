using UnityEngine;
using System.Collections;

public class selectormouse : MonoBehaviour {


	private Rigidbody2D rb2d;
	public float mode;
	void Start(){
		rb2d=GetComponent<Rigidbody2D>();
	}
		
	void FixedUpdate(){
			

	}
	void OnMouseOver(){
		if(Input.GetMouseButton(0)){
			Vector2 forces;
				forces = new Vector2 (mode*Input.GetAxis ("Mouse X"), mode*Input.GetAxis ("Mouse Y")); 
			rb2d.AddForce (forces, ForceMode2D.Impulse);

	}
}
}