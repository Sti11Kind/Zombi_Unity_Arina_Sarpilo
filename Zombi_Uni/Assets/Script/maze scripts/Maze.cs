using UnityEngine;
using UnityEngine.InputSystem;

public class Maze : MonoBehaviour
{
    private InputAction turn;
    public GameObject maze;
    public float turnSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        turn = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 turnValue = turn.ReadValue<Vector2>();
        Vector3 turnVector = new Vector3(turnValue.y, 0, -turnValue.x)* turnSpeed* Time.deltaTime;
        maze.transform.Rotate(turnVector);
        Debug.Log("turn val x: " + turnValue.x + " y: " + turnValue.y);
    }
}
