using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitShop : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GameObject btn_obj = GameObject.Find("quit_button");
        Button btn = btn_obj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            Application.Quit();
        });
    }

    // Update is called once per frame
    void Update () {
		
	}
}
