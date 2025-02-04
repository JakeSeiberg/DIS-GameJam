using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class TextController : MonoBehaviour
{
    public BikeController BikeController;

    public TextMeshProUGUI textObject; 
    private float yOffset = -22.93f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bikeScreenPosition = Camera.main.WorldToScreenPoint(BikeController.transform.position);
        bikeScreenPosition.y += yOffset;
        textObject.transform.position = bikeScreenPosition;
    }

    void points(int points)
    {
        textObject.text = points.ToString();
    }
}
