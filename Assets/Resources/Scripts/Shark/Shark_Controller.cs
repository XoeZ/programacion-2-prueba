using UnityEngine;

public class Shark_Controller : MonoBehaviour
{
    [SerializeField] private Shark_StateMachine stateMachine;

    public Shark_StateMachine StateMachine => stateMachine;

    private void Awake()
    {
        stateMachine.Initialize(this, stateMachine.Idle);
    }
}
