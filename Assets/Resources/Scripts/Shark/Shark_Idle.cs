using UnityEngine;

public class Shark_Idle : Shark_StateBase
{

    public Transform referencePosition;
    private float tiempoInicial;
    public float tiempoEnIdle;

    public override void Enter()
    {
        base.Enter();
        tiempoInicial = tiempoEnIdle;
    }

    public override void Logic()
    {
        base.Logic();
        tiempoEnIdle -= Time.deltaTime;
        Controller.transform.position = referencePosition.position;

        if(tiempoEnIdle <= 0 )
        {
            Controller.StateMachine.SwitchState(Controller.StateMachine.Idle);
        }
         
    }

    public override void FixedLogic()
    {
        base.FixedLogic();
    }

    public override void Exit()
    {
        base.Exit();
        tiempoEnIdle = tiempoInicial;
    }
}
