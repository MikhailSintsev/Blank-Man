using UnityEngine;
using UnityEngine.UI;

public class OverlayBehaviour : MonoBehaviour
{
    // Изменить цвет (изменить/вернуть прежний) изображения кнопки (снять/поставить галку)
    // в зависимости от нажатой клавиши

    public Image wImage;
    public Image sImage;
    public Image aImage;
    public Image dImage;
    public Image shiftImage;
    public Image spaceImage;
    public Image fImage;
    public Image gImage;
    public Image rImage;
    public Image cImage;
    public Image hImage;
    public Image uImage;
    public Image iImage;
    public Image oImage;
    public Image pImage;
    public Image escImage;

    public Toggle flyModeToggle;
    public Toggle gravityToggle;

    public Color firstButtonColor;
    public Color secondButtonColor;

    bool flyModeIsOn;
    bool gravityIsOn;

    private void Update()
    {
        // W - Forward (Вперед)
        if (Input.GetKeyDown(KeyCode.W))
            wImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.W))
            wImage.color = firstButtonColor;

        // S - Backward (Назад)
        if (Input.GetKeyDown(KeyCode.S))
            sImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.S))
            sImage.color = firstButtonColor;

        // A - Left (Влево)
        if (Input.GetKeyDown(KeyCode.A))
            aImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.A))
            aImage.color = firstButtonColor;

        // D - Right (Вправо)
        if (Input.GetKeyDown(KeyCode.D))
            dImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.D))
            dImage.color = firstButtonColor;

        // Shift - Acceleration (Ускорение)
        if (Input.GetKey(KeyCode.LeftShift))
            shiftImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            shiftImage.color = firstButtonColor;

        // Space - Jump (Прыжок)
        if (Input.GetKeyDown(KeyCode.Space))
            spaceImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.Space))
            spaceImage.color = firstButtonColor;

        // F - Fly (Режим полета)
        if (Input.GetKeyDown(KeyCode.F))
        {
            fImage.color = secondButtonColor;
            flyModeIsOn = !flyModeIsOn;
            flyModeToggle.isOn = flyModeIsOn;
        }
        if (Input.GetKeyUp(KeyCode.F))
            fImage.color = firstButtonColor;

        //G - Gravity (Режим гравитации)
        if (Input.GetKeyDown(KeyCode.G))
        {
            gImage.color = secondButtonColor;
            gravityIsOn = !gravityIsOn;
            gravityToggle.isOn = gravityIsOn;
        }
        if (Input.GetKeyUp(KeyCode.G))
            gImage.color = firstButtonColor;

        // R - Reload Scene (Перезагрузка сцены)
        if (Input.GetKeyDown(KeyCode.R))
            rImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.R))
            rImage.color = firstButtonColor;

        // C - Floor Color (Цвет пола)
        if (Input.GetKeyDown(KeyCode.C))
            cImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.C))
            cImage.color = firstButtonColor;

        // H - Help (Подсказка)
        if (Input.GetKeyDown(KeyCode.H))
            hImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.H))
            hImage.color = firstButtonColor;

        // U - Unlimited Spawn (Бесконечный спавн)
        if (Input.GetKeyDown(KeyCode.U))
            uImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.U))
            uImage.color = firstButtonColor;

        // I - Individual Color (Индивидуальный цвет)
        if (Input.GetKeyDown(KeyCode.I))
            iImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.I))
            iImage.color = firstButtonColor;

        // O - One Color (Общий цвет)
        if (Input.GetKeyDown(KeyCode.O))
            oImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.O))
            oImage.color = firstButtonColor;

        // P - Spawn One Object (Заспавнить один объект)
        if (Input.GetKeyDown(KeyCode.P))
            pImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.P))
            pImage.color = firstButtonColor;

        // Esc - Exit (Выход)
        if (Input.GetKeyDown(KeyCode.Escape))
            escImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.Escape))
            escImage.color = firstButtonColor;
    }
}
