using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSomething : MonoBehaviour
{
    public Text text;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int total = 0;
        foreach (Transform child in this.gameObject.transform)
        {
            if (child.name.Equals("ShoppingCart"))
            {
            }
            else
            {
                total++;
            }

        }
        text.text = "Curr:" + total.ToString();

    }
}
