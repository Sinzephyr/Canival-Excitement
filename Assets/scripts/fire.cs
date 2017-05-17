using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {


	public float timer = 3f;
	public float speed = 5f;
	public Rigidbody projectile;

	void start(){
	}
	void Update () { if (Input.GetKeyDown("space")) {
		Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed)); }
	}
}