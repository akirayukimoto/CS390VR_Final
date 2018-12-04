using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combine : MonoBehaviour
{
    public int stuff_count;
    public int num_fruits;
    public int num_foods;
    public int num_drinks;
    public int total_price;
    // Use this for initialization
    void Start()
    {
        stuff_count = 0;
        num_fruits = 0;
        num_foods = 0;
        num_drinks = 0;
        total_price = 0;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Foods")
            || col.gameObject.tag.Equals("Fruits")
            || col.gameObject.tag.Equals("drinks"))
        {
            //col.gameObject.transform.parent = this.transform;
            stuff_count++;

            if (col.gameObject.tag.Equals("Foods"))
            {
                num_foods++;
            }
            else if (col.gameObject.tag.Equals("Fruits"))
            {
                num_fruits++;
            }
            else if (col.gameObject.tag.Equals("drinks"))
            {
                num_drinks++;
            }
            total_price = num_fruits * 3 + num_foods * 5 + num_drinks * 3;

            col.gameObject.transform.parent = this.transform;
        }
        if (stuff_count == 2)
        {
            //this.transform.tag = "Plate_of_Food";
        }
    }
}