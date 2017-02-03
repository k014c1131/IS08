using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class texttap : MonoBehaviour {
	private int count =  0;

	private string[] texts = {"test"};//テキストの箱 
	public GameObject text;//テキストの場所の定義　
	//public EventSystem eventsystem; //イベントシステム（いろんなことに使う）の定義　現在使用していない

	// Use this for initialization
	void Start () {
	Debug.Log(GrovalFunction.scenarios[0].prorogs_text);
		
		text.GetComponent<Text>().text = "touch screen";
	}
	// Update is called once per frame
	void Update () {
        Debug.Log(GrovalFunction.scenariostatus);
        if (GrovalFunction.scenariostatus == -1)
        {
            texts = GrovalFunction.scenarios[0].prorogs_text;
            GrovalFunction.scenariostatus = 0;
        }
        else
        if (GrovalFunction.scenariostatus == 1)
        {
            texts = GrovalFunction.scenarios[0].epiloge_text;

        }
    }
	public void OnClick() {
		if(count == 0){
			text.GetComponent<Text>().text = "";
		}
		text.GetComponent<Text>().text = text.GetComponent<Text>().text + "\n" + texts[count];
		count++;
		if (count >= texts.Length) {
			if(GrovalFunction.scenariostatus == 0 ){
				Application.LoadLevel("main");
			} else if(GrovalFunction.scenariostatus == 1) { 
				Application.LoadLevel("title");
			}
		}//この部分でシーンを変更する
	}
}