using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class itemtext : MonoBehaviour {

    // Use this for initialization
    public GameObject item;
    public GameObject Dropdown;
    private Sprite[] images;

    private string[] texts = { "アイテムのテキスト1", "アイテムのテキスト2", "アイテムのテキスト3", "アイテムのテキスト4", "アイテムのテキスト5", "アイテムのテキスト6" };

    void Start()
    {
        images = Resources.LoadAll<Sprite>("Images/");
       
    }

    /* 処理の仮置き
     List<string> itemnamelist = new List<string>();
        if (1 == 1)
        {
            itemnamelist.Add("アイテム名");//処理を行うたびにリストを空にしないと同じ項目が追加される。
            Dropdown.GetComponent<Dropdown>().ClearOptions();//ここで、ドロップダウンの項目をすべて削除する
            Dropdown.GetComponent<Dropdown>().AddOptions(itemnamelist);//ここで、ドロップダウンの項目を増やす
        
        }
        */

    public void OnValueChanged(int result)
    {
        item.GetComponent<Text>().text = texts[Dropdown.GetComponent<Dropdown>().value] ;//resultを使っても同じかもしれない
        Image renderer = GameObject.Find("itemImage").GetComponent<Image>();
        //Dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData { text = texts[Dropdown.GetComponent<Dropdown>().value] });//アイテムの項目増やすテスト行仮置き

        renderer.sprite = images[Dropdown.GetComponent<Dropdown>().value];
        Debug.Log(1);
        
        
        
    }
    public void OnClick()
    {
        if (Dropdown.GetComponent<Dropdown>().value == 5)
        {
            //エピローグ画面に遷移
            GrovalFunction.scenariostatus = 1;
            Debug.Log(GrovalFunction.scenariostatus);
            SceneManager.LoadScene("prologue");
        }
    }
        // Update is called once per frame
        void Update () {
	
	}
}