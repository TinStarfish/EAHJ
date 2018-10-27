using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {

    public string nextSceneName;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);

    }
}
