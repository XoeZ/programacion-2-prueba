using UnityEngine;


[System.Serializable]
public class Bird_StateIdle : Bird_BaseStateMachine
{
    public Transform objectDestination;
    private float temporizadorInicialParaVolar;
    public float tiempoEnIdle;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entramos a idle, me voy pal pisito");
        temporizadorInicialParaVolar = tiempoEnIdle;
    }

    public override void Logic()
    {
        tiempoEnIdle -= Time.deltaTime;
        base.Logic();
        Controller.transform.position = Vector3.Lerp(Controller.transform.position, objectDestination.position, 2f * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(objectDestination.position - Controller.transform.position);

        Controller.transform.rotation = Quaternion.Slerp(Controller.transform.rotation, targetRotation, 0.2f * Time.deltaTime);

        if(tiempoEnIdle < 0)
        {
            Controller.StateMachine.SwitchState(Controller.StateMachine.Fly);
            tiempoEnIdle = temporizadorInicialParaVolar;
        }
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Salimos de idle");
    }
}
