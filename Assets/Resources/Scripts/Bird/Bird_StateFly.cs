using UnityEngine;
using UnityEngine.AI;


[System.Serializable]
public class Bird_StateFly : Bird_BaseStateMachine
{
    public Transform objectFlyPosition;

    public override void Enter()
    {
        base.Enter(); 
    }

    public override void Logic()
    {
        base.Logic();
        Debug.Log("Puedo volar? volemos");
        Controller.transform.position = Vector3.Lerp(Controller.transform.position, objectFlyPosition.position, 0.5f * Time.deltaTime);
        Controller.transform.LookAt(objectFlyPosition.position);
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
