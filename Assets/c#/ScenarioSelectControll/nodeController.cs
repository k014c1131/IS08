using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class nodeController : MonoBehaviour {
	GameObject text;
	string title;
	
	// Use this for initialization
	void Start () {
		text = transform.Find("Text").gameObject;
		Debug.Log(text.GetComponent<Text>().text);
		title = text.GetComponent<Text>().text + "";
	}
	public void onClick(){
		string[] titleArrayData = title.Split(':');
		GrovalFunction.selectScenario = int.Parse(titleArrayData[0]);
		//Debug.Log(text.GetComponent<Text>().text);
		SceneManager.LoadScene("prologue");
	}
	// Update is called once per frame
	void Update () {
	
	}
}
