using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlayBehaviour : MonoBehaviour
{
    public Image wImage;
    public Image sImage;
    public Image aImage;
    public Image dImage;
    public Image shiftImage;
    public Image spaceImage;
    public Image fImage;
    public Image gImage;
    public Image cImage;
    public Image hImage;
    public Image uImage;
    public Image iImage;
    public Image oImage;
    public Image pImage;

    public Toggle flyModeToggle;
    public Toggle gravityToggle;

    public Color firstButtonColor;
    public Color secondButtonColor;

    bool flyModeIsOn;
    bool gravityIsOn;

    private void Start()
    {
        firstButtonColor = wImage.color;
    }

    private void Update()
    {
        // W - Forward
        if (Input.GetKeyDown(KeyCode.W))
            wImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.W))
            wImage.color = firstButtonColor;

        // S - Backward
        if (Input.GetKeyDown(KeyCode.S))
            sImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.S))
            sImage.color = firstButtonColor;

        // A - Left
        if (Input.GetKeyDown(KeyCode.A))
            aImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.A))
            aImage.color = firstButtonColor;

        // D - Right
        if (Input.GetKeyDown(KeyCode.D))
            dImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.D))
            dImage.color = firstButtonColor;

        // Shift - Acceleration
        if (Input.GetKey(KeyCode.LeftShift))
            shiftImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            shiftImage.color = firstButtonColor;

        // Space - Jump
        if (Input.GetKeyDown(KeyCode.Space))
            spaceImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.Space))
            spaceImage.color = firstButtonColor;

        // F - Fly
        if (Input.GetKeyDown(KeyCode.F))
        {
            fImage.color = secondButtonColor;
            flyModeIsOn = !flyModeIsOn;
            flyModeToggle.isOn = flyModeIsOn;
        }
        if(Input.GetKeyUp(KeyCode.F))
            fImage.color = firstButtonColor;

        //G - Gravity
        if (Input.GetKeyDown(KeyCode.G))
        {
            gImage.color = secondButtonColor;
            gravityIsOn = !gravityIsOn;
            gravityToggle.isOn = gravityIsOn;
        }
        if (Input.GetKeyUp(KeyCode.G))
            gImage.color = firstButtonColor;

        // C - Floor Color
        if (Input.GetKeyDown(KeyCode.C))
            cImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.C))
            cImage.color = firstButtonColor;

        // H - Help
        if (Input.GetKeyDown(KeyCode.H))
            hImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.H))
            hImage.color = firstButtonColor;

        // U - Unlimited Spawn
        if (Input.GetKeyDown(KeyCode.U))
            uImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.U))
            uImage.color = firstButtonColor;

        // I - Individual Color
        if (Input.GetKeyDown(KeyCode.I))
            iImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.I))
            iImage.color = firstButtonColor;

        // O - One Color
        if (Input.GetKeyDown(KeyCode.O))
            oImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.O))
            oImage.color = firstButtonColor;

        // P - Spawn One Object
        if (Input.GetKeyDown(KeyCode.P))
            pImage.color = secondButtonColor;
        if (Input.GetKeyUp(KeyCode.P))
            pImage.color = firstButtonColor;
    }
}
