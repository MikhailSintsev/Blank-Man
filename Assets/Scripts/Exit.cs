using UnityEngine;

public class Exit : MonoBehaviour
{
    // Закрыть приложение по нажатию Esc

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
