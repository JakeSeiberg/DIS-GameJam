using UnityEngine;

public class RampUp : MonoBehaviour
{
    private int interval;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interval = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(checkForRampup()){
            RoadSpawner.gameSpeed += 5;
        }
    }

    bool checkForRampup(){
        if (GameOverChecker.score > interval){
            interval += interval;
            return true;
        }
        else{
            return false;
        }
    }
}
