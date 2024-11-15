using UnityEngine;


[System.Serializable]
public class Bird_StateHunt : Bird_BaseStateMachine
{
    public Transform playerDestination;
    private float tiempoInicialDeAtaque;
    public float tiempoDeAtaque;
    public override void Enter()
    {
        base.Enter();
        tiempoInicialDeAtaque = tiempoDeAtaque;
    }

    public override void Logic()
    {
        base.Logic();
        Debug.Log("Cazando al don cangrejo");

        Controller.transform.position = Vector3.Lerp(Controller.transform.position, playerDestination.position, 2f * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(playerDestination.position - Controller.transform.position);

        Controller.transform.rotation = Quaternion.Slerp(Controller.transform.rotation, targetRotation, 0.7f * Time.deltaTime);

        tiempoDeAtaque -= Time.deltaTime;

        if(tiempoDeAtaque <0)
        {
            Controller.StateMachine.SwitchState(Controller.StateMachine.Grab);
        }
    }

    public override void FixedLogic()
    {
        base.FixedLogic();
    }

    public override void Exit()
    {
        base.Exit();
        tiempoDeAtaque = tiempoInicialDeAtaque;
    }
}
