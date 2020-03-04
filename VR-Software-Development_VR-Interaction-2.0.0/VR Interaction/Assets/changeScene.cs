using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {
    

    public void GoToScene(string sceneName) {
        Debug.Log("My method is called" );
        SceneManager.LoadScene(sceneName);
    }
}
