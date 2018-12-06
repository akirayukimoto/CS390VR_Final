using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class counter : MonoBehaviour {
    public Text countText;
    public int stuff_count;

    public int num_fruits;
    public int num_foods;
    public int num_drinks;
    public int total_price;

    // Use this for initialization
    void Start () {
        stuff_count = 0;
        num_fruits = 0;
        num_foods = 0;
        num_drinks = 0;
        total_price = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Foods")
            || col.gameObject.CompareTag("Fruits")
            || col.gameObject.CompareTag("drinks"))
        {
            //col.gameObject.transform.parent = this.transform;
            stuff_count++;

            if (col.gameObject.CompareTag("Foods"))
            {
                num_foods++;
                SetCountText();
            }
            else if (col.gameObject.CompareTag("Fruits"))
            {
                num_fruits++;
                SetCountText();
            }
            else if (col.gameObject.CompareTag("drinks"))
            {
                num_drinks++;
                SetCountText();
            }
            total_price = num_fruits * 3 + num_foods * 5 + num_drinks * 3;
            
        }
       // SetCountText();
    }
    void SetCountText()
    {
        // Update the text field of our 'countText' variable
        countText.text = "Fruit: " + num_fruits.ToString();

        
    }

}
