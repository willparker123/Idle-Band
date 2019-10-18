using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sceneChange : MonoBehaviour
{
    public GameObject c1;
    
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void ChangeScene(string sceneName)
    {
        Time.timeScale = 0; //pauses the current scene 
        Application.LoadLevelAdditive(this.name); //loads your desired other scene
        Application.LoadLevel(sceneName);
    }
    public void OpenCanvas(GameObject canvasName)
    {
        DisableCanvas(c1);
        EnableCanvas(canvasName);
    }
    public void CloseCanvas(GameObject canvasName)
    {
        DisableCanvas(canvasName);
        EnableCanvas(c1);
    }
    private void DisableCanvas(GameObject canvas)
    {
        canvas.SetActive(false);
    }

    private void EnableCanvas(GameObject canvas)
    {
        canvas.SetActive(true);
    }
}
