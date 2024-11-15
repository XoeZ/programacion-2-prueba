using UnityEngine;


[System.Serializable]
public class Bird_StateGrab : Bird_BaseStateMachine
{
    public GameObject player;
    public Transform objectFlyPosition;
    private float temporizadorInicialParaSoltar;
    public float tiempoParaSoltar;

    public bool agarrado;


    public override void Enter()
    {
        base.Enter();
        temporizadorInicialParaSoltar = tiempoParaSoltar;
        agarrado = true;
    }

    public override void Logic()
    {
        tiempoParaSoltar -= Time.deltaTime;

        base.Logic();
        Debug.Log("me lo llevo a don cangrejo");
        Controller.transform.position = Vector3.Lerp(Controller.transform.position, objectFlyPosition.position, 0.2f * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(objectFlyPosition.position - Controller.transform.position);

        Controller.transform.rotation = Quaternion.Slerp(Controller.transform.rotation, targetRotation, 1f * Time.deltaTime);

        if(agarrado == true)
        {
            player.transform.position = Controller.transform.position;
        }

        if (tiempoParaSoltar < 0)
        {
            Controller.StateMachine.SwitchState(Controller.StateMachine.Drop);
        }
    }

    public override void FixedLogic()
    {
        base.FixedLogic();
    }

    public override void Exit()
    {
        base.Exit();
        tiempoParaSoltar = temporizadorInicialParaSoltar;
    }
}
