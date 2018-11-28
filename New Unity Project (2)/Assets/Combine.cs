using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{
    public int stuff_count;
    // Use this for initialization
    void Start()
    {
        stuff_count = 0;
    }

    // Update is called once per frame
    //void Update () {

    //}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Foods")
            || col.gameObject.tag.Equals("Fruits"))
        {
            col.gameObject.transform.parent = this.transform;
            stuff_count++;
        }
        if (stuff_count == 2)
        {
            //this.transform.tag = "Plate_of_Food";
        }
    }
}