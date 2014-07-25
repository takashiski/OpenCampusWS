using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public GameObject bullet;
	public float power = 10;
	public ForceMode forcemode = ForceMode.Impulse;

	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			Vector3 tp = transform.position;
			Vector3 pos = new Vector3(tp.x+Random.Range(-0.5f,0.5f),tp.y,tp.z);
			GameObject obj = Instantiate(bullet, pos, transform.rotation) as GameObject;
			obj.rigidbody.AddForce(power * transform.forward, forcemode);
			Destroy (obj, 3f);
		}
	}
}
