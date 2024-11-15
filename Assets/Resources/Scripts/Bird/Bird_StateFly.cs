using UnityEngine;
using UnityEngine.AI;


[System.Serializable]
public class Bird_StateFly : Bird_BaseStateMachine
{
    public Transform objectFlyPosition;
    private float temporizadorInicialParaIdle;
    public float tiempoEnVuelo = 5;


    public override void Enter()
    {
        base.Enter();
        temporizadorInicialParaIdle = tiempoEnVuelo;
    }

    public override void Logic()
    {
        tiempoEnVuelo -= Time.deltaTime;

        base.Logic();
        Debug.Log("Puedo volar? volemos");
        Controller.transform.position = Vector3.Lerp(Controller.transform.position, objectFlyPosition.position, 0.2f * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(objectFlyPosition.position - Controller.transform.position);

        Controller.transform.rotation = Quaternion.Slerp(Controller.transform.rotation, targetRotation, 1f * Time.deltaTime);

        if(tiempoEnVuelo < 0 )
        {
            Controller.StateMachine.SwitchState(Controller.StateMachine.Idle);
            tiempoEnVuelo = temporizadorInicialParaIdle;
        }
    }

    public override void FixedLogic()
    {
        base.FixedLogic();
    }

    public override void Exit()
    {
        base.Exit();
    }
}
