using UnityEngine;

public class Bird_StateMachine : StateMachine<Bird_BaseStateMachine, Bird_Controller>
{
    [SerializeField] private Bird_StateIdle idle;
    [SerializeField] private Bird_StateFly fly;
    [SerializeField] private Bird_StateHunt hunt;
    [SerializeField] private Bird_StateGrab grab;
    [SerializeField] private Bird_StateDrop drop;
    public Bird_StateIdle Idle => idle;
    public Bird_StateFly Fly => fly;
    public Bird_StateHunt Hunt => hunt;
    public Bird_StateGrab Grab => grab;
    public Bird_StateDrop Drop => drop;
    

    protected override void InitializeStates(Bird_Controller controller)
    {
        idle.Initialize(controller);
        fly.Initialize(controller);
        hunt.Initialize(controller);
        grab.Initialize(controller);
        drop.Initialize(controller);    
    }
}
