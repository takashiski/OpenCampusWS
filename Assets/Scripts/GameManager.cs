using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static float time;
	public static int target;


	// Use this for initialization
	void Start () {
		time = 60;
		target = 0;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
	}

	void OnGUI()
	{
		GUI.TextArea(new Rect(0,0,100,50),"time:"+time.ToString());
		GUI.TextArea(new Rect(100,0,100,50),"破壊："+target.ToString());


	}
}
