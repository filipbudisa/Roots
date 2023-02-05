using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

   
    public void ChangeScene(string scene){
        SceneManager.LoadScene(scene);
        GameObject.Find("Backround").GetComponent<Level>().closestMovable(new Vector2(0f,0f));
        
    }
}
