using UnityEngine;
using System.Collections;

public class BikeController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f;
    
    public float minX = -5.6f;
    
    public float maxX = 5.6f;

    private bool isInverted = false;

    void Update()
    {
        float mouseXNormalized = Input.mousePosition.x / Screen.width;

        if(isInverted)
        {
            mouseXNormalized = 1 - mouseXNormalized;
        }

        float targetX = Mathf.Lerp(minX, maxX, mouseXNormalized);

        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public void ActivateControlInversion(float duration)
    {
        // Stop any currently running inversion coroutine to reset the timer.
        StopAllCoroutines();
        StartCoroutine(InvertControlsCoroutine(duration));
    }
    
    private IEnumerator InvertControlsCoroutine(float duration)
    {
        isInverted = true;
        yield return new WaitForSeconds(duration);
        isInverted = false;
    }
}
