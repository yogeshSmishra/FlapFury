using UnityEngine;

public class ToothlessScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public LogicScript logic; // Reference to the LogicScript component
    public bool birdIsAlive = true; // Flag to check if the bird is alive
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            //Rigidbody2D component will go up(+ve y) when the space key is pressed
            myRigidbody.linearVelocity = Vector2.up * FlapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdIsAlive = false; // Set the birdIsAlive flag to false when a collision occurs
        logic.gameOver(); // Call the gameOver method from LogicScript when a collision occurs
    }
}

