using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;

    private void Start(){
        
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void PlayGame(){
        SceneManager.LoadScene("SampleScene");
  }
    
    private void ExitGame(){
        Application.Quit();
  }
}
