using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSomething : MonoBehaviour
{
    public Text text;
    public Text text2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int total = 0;
        int count = 0;
        foreach (Transform child in this.gameObject.transform)
        {
            if (child.name.Equals("ShoppingCart"))
            {
            }
            else
            {
                //total++;
                if (child.tag.Equals("Fruits"))
                {
                    total = total + 2;
                }
                else
                {
                    total++;

                }

                count++;
            }

        }
        text.text = "Price:" + total.ToString();
        text2.text = "Count: " + count.ToString();
    }
}
