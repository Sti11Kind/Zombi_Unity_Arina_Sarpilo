using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject[] zombies;
    public GameObject selectedZombie;
    public Vector3 selectedSize;
    public Vector3 pushForce;
    private InputAction next, prev;
    private InputAction jump;
    private int selectedIndex = 0;
    public TMP_Text timerText;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        next = InputSystem.actions.FindAction("NextZombie");
        prev = InputSystem.actions.FindAction("PrevZombie");
        jump = InputSystem.actions.FindAction("Jump");
        selectZombie(selectedIndex);

    }

    void selectZombie(int index)
    {
       if (selectedZombie != null)
        {
            selectedZombie.transform.localScale = Vector3.one;
        }
        selectedZombie = zombies[index];
        selectedZombie.transform.localScale = selectedSize;
        Debug.Log("selected: " + selectedZombie);
    }

    // Update is called once per frame
    void Update()
    {
        if (next.WasPressedThisFrame())
        {
            Debug.Log("next");
            selectedIndex++;
            if (selectedIndex >= zombies.Length)
                selectedIndex = 0;
            selectZombie(selectedIndex); 
        }
        if (prev.WasPressedThisFrame())
        {
            Debug.Log("prev");
            selectedIndex--;
            if (selectedIndex < 0)
                selectedIndex = 3;
            selectZombie(selectedIndex);
        }
        if (jump.WasPressedThisFrame()) 
        {
            Debug.Log("JUMP");
            Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
            if (rb != null)
                rb.AddForce(pushForce);
        }
        timer += Time.deltaTime;
        timerText.text = "Time: " + timer.ToString("F1") +"s";
    }
}
