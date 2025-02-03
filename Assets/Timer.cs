using UnityEngine;
using TMPro;
using System.Collections;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    static public float currentTime = 60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        timerText.text = currentTime.ToString("F0");
    }

    public void loseTime(int seconds)
    {
        currentTime -= seconds;
        StartCoroutine(redText());
    }


    private IEnumerator redText()
    {
        timerText.color = Color.red;
        yield return new WaitForSeconds(2f);
        timerText.color = Color.black;
    }
}
