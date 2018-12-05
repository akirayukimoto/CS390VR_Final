using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name.Equals("ShoppingCart")) {
            col.gameObject.transform.DetachChildren();
           // Destroy(col.gameObject);
        }
    }
}
