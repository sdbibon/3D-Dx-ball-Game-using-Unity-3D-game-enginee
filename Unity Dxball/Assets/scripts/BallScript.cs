using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rigidbody.AddForce(0, 250f, 100f);
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > 3.8 && transform.position.x < 4)
        {
             
        }
	
	}
}
