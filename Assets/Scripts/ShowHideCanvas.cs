using UnityEngine;

public class ShowHideCanvas : MonoBehaviour
{
    // Показать/скрыть подсказку по нажатию клавиши H (активирует триггеры
    // аниматоров двух холстов (Overlay Canvas и Help Window Canvas))

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
