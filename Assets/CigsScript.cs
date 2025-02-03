using UnityEngine;

public class CigsScript : MonoBehaviour
{
    private SpriteRenderer cigsRenderer;
    public Sprite[] cigsImages;

    static public int cigsCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cigsRenderer = GetComponent<SpriteRenderer>();
        cigsCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cigsRenderer.sprite = cigsImages[cigsCount % cigsImages.Length];
        if(cigsCount > 7){
            Timer.currentTime += 30;
            cigsCount = 0;
        }
    }
}
