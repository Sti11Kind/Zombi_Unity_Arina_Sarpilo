using UnityEngine;

public class LoseScript : MonoBehaviour
{
    // working only when zombie touch the dead zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if it is a zombie
        if (other.GetComponent<Rigidbody>() != null)
        {
            // request GameManager to stop the game
            GameManager.instance.ShowGameOver();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
