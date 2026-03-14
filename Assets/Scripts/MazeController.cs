using UnityEngine;
using UnityEngine.InputSystem;

public class MazeController : MonoBehaviour
{
    public GameObject maze;
    public float rotationSpeed = 5;

    private InputAction rotateImput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotateImput = InputSystem.actions.FindAction("Player/Move");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 rotation = rotateImput.ReadValue<Vector2>();
        maze.transform.Rotate(
            rotation.y * rotationSpeed * Time.deltaTime,0, -rotation.x * rotationSpeed * Time.deltaTime);
    }
}
