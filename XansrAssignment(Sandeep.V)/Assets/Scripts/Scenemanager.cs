using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{
    public Image fade;
    // Start is called before the first frame update
    void Start()
    {
        fade.canvasRenderer.SetAlpha(0.0f);
        fadein();
    }

   
    void fadein()
    {
        fade.CrossFadeAlpha(1, 2, false);
    }

   public void GameScene()
    {
        SceneManager.LoadScene(1);
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(1);
        ScoreManager.score = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }
   
}
