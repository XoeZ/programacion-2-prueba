using Clases.PA2024.Management;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    private void OnStateChange(GameState state)
    {
        if (state == GameState.Gameplay)
        {
            Time.timeScale = 1f;
            UIManager.Instance.SwitchPanel("Gameplay");
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
