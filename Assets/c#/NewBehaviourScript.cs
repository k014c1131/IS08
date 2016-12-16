using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public string textToEdit = "TextField";
    public Rect zahyou1 = new Rect(0, 0, 100, 50);
    public Rect zahyou2 = new Rect(50, 0, 100, 50);
    public Rect zahyou3 = new Rect(100, 0, 100, 50);
    public int width = Screen.width;
    public int height = Screen.height;
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
        if (GUI.Button(new Rect(width/2, height/2, 100, 50), "Click"))
        {
            
            textToEdit = GUI.TextArea(new Rect(width / 2, height / 4, 100, 100), "start "+width+" "+height);
            //Application.LoadLevel("test");
        }
        // テキストフィールドを表示する
        textToEdit = GUI.TextArea(new Rect(width / 2, height / 4, 100, 100), textToEdit,1000);
    }
    // Use this for initialization
    void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
	static void tap(){
		Application.LoadLevel("test3");
	}

}
