using UnityEngine;

public class PillarMiddleScript : MonoBehaviour
{

    public LogicScript logic; // Reference to the LogicScript component
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.addScore(1); // Call the addScore method from LogicScript when a collision occurs    
        }
        
    }
}
