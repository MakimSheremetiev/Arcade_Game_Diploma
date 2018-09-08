using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class menu : MonoBehaviour {
	
	public GUIStyle mystyle, start, exit;
	string score; 
	void Start () 
	{
		StreamReader scoredata = new StreamReader (Application.persistentDataPath + "/score.gd"); //создание файловой переменной
		score = scoredata.ReadLine ();
		scoredata.Close (); 
	}
	
	
	void Update () {
		
	}
	void OnGUI(){
		GUI.Box (new Rect (Screen.width*0.15f, Screen.height*0.8f, Screen.width*0.7f, Screen.height*0.1f), "BEST SCRORE:"+score,mystyle); 
		if (GUI.Button (new Rect (Screen.width*0.15f, Screen.height*0.4f, Screen.width*0.7f, Screen.height*0.1f), "",start)) 
		{
			Application.LoadLevel(1);//Загрузка игровой сцены
		}
		if (GUI.Button (new Rect (Screen.width*0.15f, Screen.height*0.7f, Screen.width*0.7f, Screen.height*0.1f), "",exit))
		{
			Application.Quit();
		}
	}
}