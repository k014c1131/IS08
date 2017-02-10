using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using model;

public class GrovalFunction : MonoBehaviour {
	public static List<scenarioData> scenarios = new List<scenarioData>();
	public static int selectScenario; //選択したシナリオ番号を保持。初期値は-1
	public static int scenariostatus;   //-1 初期値 0 プロローグ通過 1　アイテム全取得
	// Use this for initialization
	void Start () {
		scenarios = publicFunction.getScenarios();
	}
	public static void resetStatus(){		
		selectScenario = -1;
		scenariostatus = -1;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
