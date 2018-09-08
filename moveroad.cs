using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
public class moveroad : MonoBehaviour {
	
	public GUIStyle mystyle;
	float score=0,speed=-2f;
	
	void Start () 
	{

	}
	
	
	void Update () 
	{
		transform.Translate (new Vector3 (0f, speed, 0f));
		score = score + (speed*-1);
		if (transform.position.y < -50f) { 
			transform.Translate(new Vector3 (0f, 100f, 0f));
		}
	}


}