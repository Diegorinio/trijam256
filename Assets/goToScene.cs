using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToScene : MonoBehaviour
{
    public string sceneName;
    public void goToSceneName(){
        SceneManager.LoadScene(sceneName);
    }
}
