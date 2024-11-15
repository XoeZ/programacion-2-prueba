using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public TextMeshProUGUI m_text;
    public int m_minutes;
    public int m_seconds = 0;
    public bool plus = true;

    float totalTime;
    void Start() => totalTime = m_minutes * 60 + m_seconds;

    void Update() => Clock(plus);

    void Clock(bool countUp)
    {
        totalTime += (countUp ? 1 : -1) * Time.deltaTime; // Si se suma o se resta

        int minutes = Mathf.FloorToInt(totalTime / 60); // Elimina los decimales, redondeando hacia abajo. (4.7 = 4)
        int seconds = Mathf.FloorToInt(totalTime % 60);

        minutes = Mathf.Max(minutes, 0); // Indica que el valor no debe bajar de 0.
        seconds = Mathf.Max(seconds, 0);

        m_text.text = $"{minutes:D2}:{seconds:D2}"; // D2 sirve para mostrar solo los digitos.

        if(minutes == 0 && seconds == 0)
        {
            GameManager.SwitchState(GameState.Victory);
        }
    }
}
