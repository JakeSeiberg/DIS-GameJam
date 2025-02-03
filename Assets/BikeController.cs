using UnityEngine;

public class BikeController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f;
    
    public float minX = -5.6f;
    
    public float maxX = 5.6f;

    void Update()
    {
        float mouseXNormalized = Input.mousePosition.x / Screen.width;

        float targetX = Mathf.Lerp(minX, maxX, mouseXNormalized);

        Vector3 targetPosition = new Vector3(targetX, transform.position.y, transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
