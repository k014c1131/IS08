using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using System.Collections;

public class texttap : MonoBehaviour {
	public int score = 100;
	
	public Ray ray;
	public Ray rayItem;
	public RaycastHit hit;
	public GameObject selectedGameObject;

	public GameObject text; //カメラの定義
	public EventSystem eventsystem; //イベントシステム（いろんなことに使う）の定義

	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.phase == TouchPhase.Began)
			{
				Debug.Log("レッドスイッチを押した");
				this.GetComponent<Text>().text = "点数 100 点";
			}
			else if (touch.phase == TouchPhase.Moved)
			{
				// タッチ移動
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				// タッチ終了
			}
		}


	}
	public void OnClick() {
		text.GetComponent<Text>().text = "点数 100 点";
	}


}