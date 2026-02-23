using UnityEngine;

public class Item : MonoBehaviour
{
    // Starts if zombie touches the coin
    private void OnTriggerEnter(Collider other)
    {
        // check if zombie have rigidbody
        if (other.GetComponent<Rigidbody>() != null)
        {
            // appeal to GameManager and add score points
            GameManager.instance.AddScore();
            
            // Remove coin from scene
            Destroy(gameObject);
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
