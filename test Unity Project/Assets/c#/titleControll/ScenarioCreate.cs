using UnityEngine;
using System.Collections;

public class ScenarioCreate : MonoBehaviour {

	public void onClick(){
		Debug.Log("createonClicked!");
		Application.OpenURL("http://example.com");
	}
}
