using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public Vector3 inputMovement;

    public float speed;
    public Transform cameraRotation;


    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, cameraRotation.eulerAngles.y, transform.eulerAngles.z);
    }

    public void Move(InputAction.CallbackContext context)
    {
        inputMovement = context.ReadValue<Vector2>();
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

        rb.linearVelocity = moveDirection * speed + new Vector3(0, rb.linearVelocity.y, 0);
    }
}
