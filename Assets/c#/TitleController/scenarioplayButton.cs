using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class scenarioplayButton : MonoBehaviour {

	public void onClick(){
		SceneManager.LoadScene("scenarioSelect");
		Application.LoadLevel("scenarioSelect");
	}
}
