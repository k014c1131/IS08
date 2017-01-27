using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

namespace model{
public class model : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public class item : MonoBehaviour {
 	public string name{ get; set; }				//アイテムの名前
 	public string pic{ get; set; } 				//アイテムのARマーカーの画像ターゲットID
 	public string[] introduction{ get; set; } 		//アイテムの説明文
 	public string target_id { get; set; }
 	public bool get_status { get; set; }
 	public item(string name,string pic,string[] introduction,string target_id){
 		this.name = name;
 		this.pic = pic;
 		this.introduction = introduction;
 		this.target_id = target_id;
 		this.get_status = false;
 	}	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
public class scenarioData : MonoBehaviour {
	public string name{ get; set; }
	public List<item> items{ get; set; }
	public string[] prorogs_text{ get; set; }
	public string[] epiloge_text{ get; set; }
	public TimeSpan limit_time{ get; set; }
	public scenarioData(string name,List<item> items,string[] prorogs_text,string[] epiloge_text,TimeSpan limit_time){
		this.name = name;
		this.items = items;
		this.prorogs_text = prorogs_text;
		this.epiloge_text = epiloge_text;
		this.limit_time = limit_time;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
}