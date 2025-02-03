using UnityEngine;

public class BeerPickup : MonoBehaviour
{
    [Tooltip("Duration (in seconds) for which the bike controls will be inverted.")]
    public float inversionDuration = 5f;

	private float speed = RoadSpawner.gameSpeed;

    [Tooltip("How long does the obstacle life before it is automatically destroyed, in seconds")]
    public float lifeTime = 10;
    Vector2 direction = new Vector2();

    private Timer time;

    void Start()
    {
        direction = new Vector2(0,-1);
        direction.Normalize();

        time = FindFirstObjectByType<Timer>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(direction.x, direction.y, 0) * speed * Time.deltaTime;
		lifeTime -= Time.deltaTime;
		if(lifeTime <= 0){
			Destroy(gameObject);
		}
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object has a BikeController component.
        BikeController bike = other.GetComponent<BikeController>();
        if (bike != null)
        {
            // Invert the bike's controls for the specified duration.
            bike.ActivateControlInversion(inversionDuration);
            time.loseTime(5);
            
            // Optionally, add sound or visual effects here.
            
            // Destroy the beer pickup after the collision.
            Destroy(gameObject);
        }
    }
}

