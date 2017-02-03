using UnityEngine;
using System.Collections;

public class testAddNode : MonoBehaviour {

    [SerializeField]
    GameObject prefab;//この部分にプレハブを設定する。設定はunity側で行う。
   
    // Use this for initialization
    void Start () {

        for (int i = 0; i < 15; i++)
        {
            var item = Instantiate(prefab);
           
             item.transform.parent = GameObject.Find("Content").transform;
            Debug.Log("123");
           
            //item.SetParent(transform, false);

            //var text = item.GetComponentInChildren<Text>();
            //text.text = "item:" + i.ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
