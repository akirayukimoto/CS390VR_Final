using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sticky : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.parent = gameObject.transform;
    }
}
