using UnityEngine;

public class CursorLock : MonoBehaviour
{
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
