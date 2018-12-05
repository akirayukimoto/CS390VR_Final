using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldCart : MonoBehaviour
{

    void Awake()
    {
        //GameObject obj = GameObject.Find("ShoppingCart");

        DontDestroyOnLoad(this.gameObject);
    }
}
