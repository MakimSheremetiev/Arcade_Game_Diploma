using UnityEngine;
using System.Collections;

public class cars : MonoBehaviour {
	public GUIStyle btnr, btnl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () 
	{
		
	}

	public void OnGUI()
	{
		if (GUI.RepeatButton (new Rect (1f,1f,140f,500f), "", btnr)) //движение влево
		{
			if (transform.position.x > -15f)
			{
				transform.Translate (new Vector3 (0f, 0.1f, 0f));
			}
		}
		
		if (GUI.RepeatButton (new Rect (140f,1f,140f,500f), "", btnl)) //движение вправо
		{

			if (transform.position.x < 15f)
			{
				transform.Translate (new Vector3 (0f, -0.1f, 0f));
			}


		}
	}
}
