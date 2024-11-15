using Clases.PA2024.Management;
using UnityEngine;

public class VictoryManager : MonoBehaviour
{
    private void OnStateChange(GameState state)
    {
        if (state == GameState.Victory)
        {
            UIManager.Instance.SwitchPanel("Victory");
            Time.timeScale = 0;
        }
    }

    private void OnEnable()
    {
        GameManager.OnStateChange += OnStateChange;
    }

    private void OnDisable()
    {
        GameManager.OnStateChange -= OnStateChange;
    }
}
