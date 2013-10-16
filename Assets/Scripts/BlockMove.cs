using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {

	Vector3 basePosition = Vector3.zero;
	// Use this for initialization
	void Start () {
	 basePosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


        //basePosition += new Vector3( 10f * Time.deltaTime, 0f, 0f );

        // makes a ball hover using CODE, not with Unity's physics engine at all
        transform.position = basePosition + new Vector3( Mathf.Sin( Time.time) * 25f, 0f, 0f );
		
		if (Time.time > 30f){
			      transform.position = basePosition + new Vector3( 0f, 0f, Mathf.Sin( Time.time) * 25f );
		}
			

    }
}
