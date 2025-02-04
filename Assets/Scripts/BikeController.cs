using UnityEngine;
using System.Collections;
using UnityEngine.UIElements;

public class BikeController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f;
    
    public float minX = -5.6f;
    
    public float maxX = 5.6f;

    private bool isInverted = false;
    private float iFrameDuration;

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
    void OnCollisionEnter2D(Collision2D other){
        StartCoroutine(IFrameCoroutine());
    }
    private IEnumerator IFrameCoroutine()
    {
        yield return new WaitForSeconds(0.5f);
        Physics2D.IgnoreLayerCollision(6,7, true);
        print("bruh");
        yield return new WaitForSeconds(1);
        Physics2D.IgnoreLayerCollision(6,7, false);
        Vector3 playerPosition = transform.position;
        playerPosition.y = -3.5f;
        transform.position = playerPosition;
    }
}
