using UnityEngine;

public class Exit : MonoBehaviour
{
    // ������� ���������� �� ������� Esc

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }
}
