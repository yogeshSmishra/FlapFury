using UnityEngine;

public class PillarMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -30; // Position at which the pillar will be destroyed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); // Destroy the pillar when it goes past the dead zone.
        }
    }
}
