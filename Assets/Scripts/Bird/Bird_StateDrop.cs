using UnityEngine;


[System.Serializable]
public class Bird_StateDrop : Bird_BaseStateMachine
{
    public override void Enter()
    {
        base.Enter();
    }

    public override void Logic()
    {
        base.Logic();
        Debug.Log("Soltando a don cangrejo");
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
