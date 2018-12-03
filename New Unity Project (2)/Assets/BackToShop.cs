using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToShop : MonoBehaviour {

    void Start()
    {
        GameObject btn_obj = GameObject.Find("Button");
        Button btn = btn_obj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            this.GoNextScene(btn_obj);
        });
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void GoNextScene(GameObject Nscene)
    {
        Application.LoadLevel("SampleScene");
    }
}
