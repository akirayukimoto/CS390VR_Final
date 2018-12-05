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
        //int i = 0;
        //while (i < col.gameObject.transform.childCount)
        //{
         //   Transform trans = col.gameObject.transform.GetChild(i);
          //  Destroy(trans.gameObject.GetComponent("Basic Grabbable"));
          //  i++;
        //}
        col.gameObject.transform.DetachChildren(); 
    }
}
