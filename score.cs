using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	public GUIStyle mystyle;
	float scores=0,speed=-2f;
	void Start () {
	
	}

	void Update () {
		scores = scores + (speed*-1);
	}
	void OnGUI(){
		GUI.Box (new Rect (50, 10, Screen.width*0.5f, Screen.height*0.1f),"SCORE " + scores, mystyle);
	}


}
