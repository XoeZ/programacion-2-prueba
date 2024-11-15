using Clases.PA2024.Management;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
	private void OnStateChange(GameState state)
	{
		if(state == GameState.Pause)
		{
			Time.timeScale = 0f;
			UIManager.Instance.SwitchPanel("Pause");
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