using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using model;
using System.Collections.Generic;

public class addNode : MonoBehaviour {   
	[SerializeField]
   GameObject prefab;//この部分にプレハブを設定する。設定はunity側で行う。

   // Use this for initialization
   void Start () {
	List<scenarioData> scenarios = publicFunction.getScenarios();
		
       for (int i = 0; i < scenarios.Count; i++)
       {
           var item = Instantiate(prefab);
            item.transform.parent = GameObject.Find("Content").transform;//ここで親オブジェクトを設定する
           var text = item.GetComponentInChildren<Text>();
           text.text = i + scenarios[i].name;
       }
   }
    
    // Update is called once per frame
    void Update () {
    
    }	
}
