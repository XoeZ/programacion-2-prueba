using Unity.VisualScripting;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    public Vector3 inputMovement;

    public float speed;
    public Transform cameraRotation;

    public GameObject cameraPlayer;

    public float vida;


    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, cameraRotation.eulerAngles.y, transform.eulerAngles.z);

        if(vida ==0)
        {
            GameManager.SwitchState(GameState.GameOver);
            Debug.Log("Has muerto");
        }
    }

    public void Move(Vector2 move)
    {
        inputMovement = move;
    }

    public void ChangeCamera()
    {
        if(cameraPlayer != null)
        {
            cameraPlayer.SetActive(!cameraPlayer.activeSelf);
        }
    }

    public void Pause()
    {
        GameManager.SwitchState(GameState.Pause);
        
        Debug.Log("Esta en pausa");
    }

    public void UnPause()
    {
        GameManager.SwitchState(GameState.Gameplay);
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

    private void OnEnable()
    {
        InputManager.Move += Move;
        InputManager.Pause += Pause;
        InputManager.Interactions += ChangeCamera;
        
    }

    private void OnDisable()
    {
        InputManager.Move -= Move;
        InputManager.Pause -= Pause;
        InputManager.Interactions -= ChangeCamera;
    }
}
