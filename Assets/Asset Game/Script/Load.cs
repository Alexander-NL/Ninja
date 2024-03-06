using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public void ChangeScene (string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
