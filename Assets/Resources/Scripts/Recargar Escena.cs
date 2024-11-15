using UnityEngine;
using UnityEngine.SceneManagement;

public class RecargarEscena : MonoBehaviour
{
    public string nombreEscena;
    public void ReloadScene()
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
