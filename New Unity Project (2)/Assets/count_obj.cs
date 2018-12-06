using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count_obj : MonoBehaviour {
    public GameObject obj;
    public Text res;

	// Use this for initialization
	void Start () {
        GameObject btn_obj = GameObject.Find("StartCheckout");
        Button btn = btn_obj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {

        });
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
