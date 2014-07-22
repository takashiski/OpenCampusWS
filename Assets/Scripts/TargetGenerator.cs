using UnityEngine;
using System.Collections;

public class TargetGenerator : MonoBehaviour {

	public GameObject target;
	public float height;

	// Use this for initialization
	void Start () {
		Vector3 center = new Vector3(transform.position.x,height,transform.position.z);
		for(int i=0;i<100;i+=1)
		{
			Vector3 position = new Vector3(Random.Range(-100,100),0,Random.Range(-100,100));
			Instantiate(target,position + center,transform.rotation);
		}
	}
}
