using Unity.Burst.CompilerServices;
using UnityEngine;

public class Shark_StateMachine : StateMachine<Shark_StateBase, Shark_Controller>
{
    [SerializeField] private Shark_Idle idle;
    public Shark_Idle Idle => idle;



    protected override void InitializeStates(Shark_Controller controller)
    {
        idle.Initialize(controller);

    }
}
