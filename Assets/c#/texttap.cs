using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class texttap : MonoBehaviour {
    private int count =  0;

    private string[] texts = {"1行目", "2行目", "3行目", "4行目" }; 

	public GameObject text; //テキストの場所の定義　
	public EventSystem eventsystem; //イベントシステム（いろんなことに使う）の定義　現在使用していない

	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
	}
	public void OnClick() {
		text.GetComponent<Text>().text = text.GetComponent<Text>().text + "\n" + texts[count];
        count++;
        //if (count == texts.Length) { };//この部分でシーンを変更する？
	}


}