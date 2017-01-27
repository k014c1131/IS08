using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class texttap : MonoBehaviour {
	private int count =  0;

	private string[] texts; //テキストの場所の定義　
	public EventSystem eventsystem; //イベントシステム（いろんなことに使う）の定義　現在使用していない

// Use this for initialization
	void Start () {
		if(GrovalFunction.scenariostatus == -1){
			texts = GrovalFunction.scenarios.prorogs_text; 
		}else if(GrovalFunction == 1){
			texts = GrovalFunction.scenarios.epiloge_text; 

		}
	}


// Update is called once per frame
void Update () {
}
public void OnClick() {
	text.GetComponent<Text>().text = text.GetComponent<Text>().text + "\n" + texts[count];
	count++;
	if (count == texts.Length) { 
		if(GrovalFunction.scenariostatus == -1 ){
			Application.LoadLevel("main");
		} else if(GrovalFunction.scenariostatus == 1) { 
			Application.LoadLevel("title");
		}
};//この部分でシーンを変更する？
}


}