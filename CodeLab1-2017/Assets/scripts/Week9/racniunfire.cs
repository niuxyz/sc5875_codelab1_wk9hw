using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racniunfire : BasicGun {

	public override void Fire (Vector3 dir, Vector3 modPos){
		print("Fired a shot: " + name);
		Vector3 randomDir = new Vector3(0,0, Random.Range(-20.0f,20.0f));
		Vector3 shootDir = new Vector3 (Random.Range (-1.0f, 1.0f), Random.Range (-1.0f, 1.0f), 0);

		GameObject bullet = Instantiate(Resources.Load("Prefabs/Bullet")) as GameObject;
		bullet.transform.position = transform.position + shootDir;
		bullet.GetComponent<Rigidbody>().velocity = shootDir;

		bullet.GetComponent<Rigidbody> ().angularVelocity = randomDir; 
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
