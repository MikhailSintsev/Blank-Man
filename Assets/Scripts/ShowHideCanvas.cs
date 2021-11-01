using UnityEngine;

public class ShowHideCanvas : MonoBehaviour
{
    // ��������/������ ��������� �� ������� ������� H (���������� ��������
    // ���������� ���� ������� (Overlay Canvas � Help Window Canvas))

    public Animator helpCanvasAnimator;
    public Animator overlayFadeInOut;

    bool showHelpCanvas = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (showHelpCanvas == false)
            {
                showHelpCanvas = true;
                helpCanvasAnimator.SetTrigger("Show");
                overlayFadeInOut.SetTrigger("Fade In");
            }
            else
            {
                showHelpCanvas = false;
                helpCanvasAnimator.SetTrigger("Hide");
                overlayFadeInOut.SetTrigger("Fade Out");
            }
        }
    }
}
