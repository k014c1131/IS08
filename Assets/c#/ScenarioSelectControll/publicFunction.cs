using UnityEngine;
using System;
using System.Collections;
using model;
using System.Collections.Generic;

public class publicFunction : MonoBehaviour {
	// Use this for initialization
	void Start () {
	}
	public static List<scenarioData> getScenarios(){
	List<scenarioData> scenarios = new List<scenarioData>();
		//DBにデータを問い合わせる処理
		string result = "DBにデータを問い合わせる処理";
		//シナリオデータの数だけjを繰り返す
		for(int j = 0;j < 1 ;j++){
			string name = "テストシナリオデータ";
			List<item> items = new List<item>();
			//アイテムの数だけiを繰り返す
			for (int i = 0;i < 1 ;i++){
				string item_name = "アイテムテストデータ";
				string pic = "../../吉田君.jpg";
				string[] introduction = new string[]{"アイテム説明","文章","テスト"};
				string target_id = "testdigestid";
				items.Add(new item(item_name,pic,introduction,target_id));
			}
			string[] prorogs_text = new string[]{"1行目","2行目","3行目","4行目"};
			string[] epiloge_text = new string[]{"1行目","2行目","3行目","4行目"}; 
			TimeSpan limit_time = new TimeSpan(1, 0, 0);
			scenarios.Add(new scenarioData(name,items,prorogs_text,epiloge_text,limit_time));
		}
		return scenarios;
	}
	// Update is called once per frame
	void Update () {

	}
}