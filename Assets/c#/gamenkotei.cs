using UnityEngine;
using System.Collections;

public class gamenkotei : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{
		switch (Screen.orientation) {
		// 縦画面のとき
		case ScreenOrientation.LandscapeLeft:
			// 左回転して左向きの横画面にする
			Screen.orientation = ScreenOrientation.Portrait;
			break;
		// 上下反転の縦画面のとき
		case ScreenOrientation.LandscapeRight:
			// 右回転して左向きの横画面にする
			Screen.orientation = ScreenOrientation.Portrait;
			break;
		}
	}
}
