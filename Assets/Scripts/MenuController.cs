using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    
    public void OnPlayButton(){
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton(){
        Application.Quit();
    }

    public void OnPlayAgainButton(){
        SceneManager.LoadScene(0);
    }

}
