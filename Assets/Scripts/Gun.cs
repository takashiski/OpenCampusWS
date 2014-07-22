using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	public GameObject bullet;
	public float power = 10;
	public ForceMode forcemode = ForceMode.Impulse;

	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			GameObject obj = Instantiate(bullet, transform.position, transform.rotation) as GameObject;
			obj.rigidbody.AddForce(power * transform.forward, forcemode);
			Destroy (obj, 3f);
		}
	}
}
