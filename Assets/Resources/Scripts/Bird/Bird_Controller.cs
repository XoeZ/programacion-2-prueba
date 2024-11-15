using UnityEngine;

public class Bird_Controller : MonoBehaviour
{
    [SerializeField] private Bird_StateMachine stateMachine;

    public Bird_StateMachine StateMachine => stateMachine;

    private void Awake()
    {
        stateMachine.Initialize(this, stateMachine.Idle);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            StateMachine.SwitchState(StateMachine.Fly);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StateMachine.SwitchState(StateMachine.Idle);
        }
    }
}
