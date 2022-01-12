using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    void Start()
    {
        PrintInstructions(); 
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }

    private void PrintInstructions()
    {
        Debug.Log("Hello Player, use WASD to move the player");
    }
}
