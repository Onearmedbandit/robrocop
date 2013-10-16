using UnityEngine;
using System.Collections;

public class HoverScript : MonoBehaviour {
	
	public float hoverVelocity = 9.8f;
	public float ascentVelocity = 15f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void FixedUpdate() {
	if(Input.GetKey (KeyCode.Space)){
			//rigidbody.AddForce(Vector3.up * hoverVelocity);
			transform.localPosition = new Vector3(0f,5f,0f);
		}
			if(Input.GetKey (KeyCode.UpArrow)){
				rigidbody.AddForce(Vector3.up  * ascentVelocity);
			}
	
	}
}
