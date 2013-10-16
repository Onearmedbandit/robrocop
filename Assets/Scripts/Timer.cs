using UnityEngine;
using System.Collections;
 
public class Timer: MonoBehaviour 
{
  private float startTime;
  private float elapsedTime;
 
  void Awake(){
    startTime = 1f;      
  }
 
  void Update () {
 
    if (startTime > 0)
    {
       elapsedTime = Time.time;
    }
  }
 
 
  void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			startTime = 0;
		}
	}
 
  void OnGUI(){
    GUI.Label(new Rect(300, 100, 100, 20), (elapsedTime.ToString()));
		GUI.Label(new Rect(200, 50, 100, 20), "WASD To Move, Dont get knocked off");
  }
}