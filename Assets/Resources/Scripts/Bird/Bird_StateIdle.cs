using UnityEngine;


[System.Serializable]
public class Bird_StateIdle : Bird_BaseStateMachine
{
    public Transform objectDestination;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Entramos a idle, me voy pal pisito");
    }

    public override void Logic()
    {
        base.Logic();
        Controller.transform.position = Vector3.Lerp(Controller.transform.position, objectDestination.position, 2f * Time.deltaTime);
        Controller.transform.LookAt(objectDestination.position);
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Salimos de idle");
    }
}
