using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
public class MenuController : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    public void setVolume(){
        mixer.SetFloat("MasterVolume", volumeSlider.value);
    }
    
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
