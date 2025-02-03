using UnityEngine;

public class CigsScript : MonoBehaviour
{
    private SpriteRenderer cigsRenderer;
    public Sprite[] cigsImages;

    public int cigsCount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cigsRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        cigsRenderer.sprite = cigsImages[cigsCount % cigsImages.Length];
        
    }
}
