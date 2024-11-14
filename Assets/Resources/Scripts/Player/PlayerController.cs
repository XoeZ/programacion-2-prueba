using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public float speed;
    public Vector2 inputMovement;
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0;
        right.y = 0;
        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = forward * inputMovement.y + right * inputMovement.x;

        rb.linearVelocity = moveDirection * speed + new Vector3(0, rb.linearVelocity.y, 0); // Conserva la velocidad vertical para la gravedad
    }
}
