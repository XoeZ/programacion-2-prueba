using Clases.PA2024.Management;
using UnityEngine;

public class GameOVerManager : MonoBehaviour
{
    private void OnStateChange(GameState state)
    {
        if (state == GameState.GameOver)
        {
            UIManager.Instance.SwitchPanel("GameOver");
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
