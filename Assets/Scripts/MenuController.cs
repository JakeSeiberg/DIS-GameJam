using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void OnPlayButton(){
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton(){
        Application.Quit();
    }

}
