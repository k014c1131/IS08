using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using model;

public class itemtext : MonoBehaviour {

    // Use this for initialization
    public GameObject item;
    public static GameObject Dropdown;
    private Sprite[] images;
   
    void Start () {
	images = Resources.LoadAll<Sprite>("Images/");


    }

    /* 処理の仮置き
     List<string> itemnamelist = new List<string>();
     if(アイテムをゲットしたら){
     itemnamelist.Add("アイテム名");//処理を行うたびにリストを空にしないと同じ項目が追加される。
        Dropdown.GetComponent<Dropdown>().AddOptions(itemnamelist);//ここで、ドロップダウンの項目を増やす
        }
        */
    public scenarioData selectScenario;
    private static string[] texts; 
    //= { "アイテムのテキスト1", "アイテムのテキスト2", "アイテムのテキスト3", "アイテムのテキスト4", "アイテムのテキスト5", "アイテムのテキスト6" };
    public static List<string> itemnamelist = new List<string>();
    void Start()
    {
        images = Resources.LoadAll<Sprite>("Images/");
        selectScenario = GrovalFunction.scenarios[GrovalFunction.selectScenario];
        for(int i = 0;i < selectScenario.items.Count;i++){
            texts[i] = selectScenario.items[i].name;
        }
    }
    public static void item_add_pulldown(int item_num){
        
            itemnamelist.Add(texts[item_num]);//処理を行うたびにリストを空にしないと同じ項目が追加される。
            Dropdown.GetComponent<Dropdown>().ClearOptions();//ここで、ドロップダウンの項目をすべて削除する
            Dropdown.GetComponent<Dropdown>().AddOptions(itemnamelist);//ここで、ドロップダウンの項目を増やす
        
        
    }

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
            SceneManager.LoadScene("prologue");
        }
    }
        // Update is called once per frame
        void Update () {
	
	}
}