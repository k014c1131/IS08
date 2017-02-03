using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class scenarioplayButton : MonoBehaviour {

	public void onClick(){
        GrovalFunction.selectScenario = -1;
        GrovalFunction.scenariostatus = -1;

        SceneManager.LoadScene("scenarioSelect");
		Application.LoadLevel("scenarioSelect");
	}
}
