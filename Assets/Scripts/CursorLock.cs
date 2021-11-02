using UnityEngine;

public class CursorLock : MonoBehaviour
{
    // Режим блокировки и невидимости курсора в инспекторе

    [SerializeField] private bool _lockCursor;

    void Update()
    {
        if (_lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
