using UnityEngine;


[System.Serializable]
public class Bird_StateDrop : Bird_BaseStateMachine
{
    public Transform objectFlyPosition;
    private float temporizadorInicialParaContinuarVuelo;
    public float tiempoEnVuelo = 5;

    public bool hunt;


    public override void Enter()
    {
        base.Enter();
        temporizadorInicialParaContinuarVuelo = tiempoEnVuelo;
    }

    public override void Logic()
    {
        tiempoEnVuelo -= Time.deltaTime;

        base.Logic();
        Debug.Log("lo he soltao");
        Controller.transform.position = Vector3.Lerp(Controller.transform.position, objectFlyPosition.position, 0.2f * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(objectFlyPosition.position - Controller.transform.position);

        Controller.transform.rotation = Quaternion.Slerp(Controller.transform.rotation, targetRotation, 1f * Time.deltaTime);

        if (tiempoEnVuelo < 0)
        {
            Controller.StateMachine.SwitchState(Controller.StateMachine.Hunt);
            tiempoEnVuelo = temporizadorInicialParaContinuarVuelo;
            Controller.StateMachine.SwitchState(Controller.StateMachine.Fly);
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
