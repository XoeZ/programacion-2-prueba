using Clases.PA2024.Management;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            UIManager.Instance.SwitchPanel("Dead");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UIManager.Instance.SwitchPanel("Pause");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            UIManager.Instance.SwitchPanel("Gameplay");
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            UIManager.Instance.SwitchPanel("Tutorial");
        }
    }
}
