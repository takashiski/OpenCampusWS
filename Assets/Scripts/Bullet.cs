using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public GameObject ptcl;

	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.tag == "Target")
		{
			GameObject obj = Instantiate(ptcl,transform.position,ptcl.transform.rotation) as GameObject;
			Destroy (obj,3);
			Destroy(c.gameObject);
			GameManager.target+=1;
		}
	//	Destroy (this.gameObject);
	}
}
