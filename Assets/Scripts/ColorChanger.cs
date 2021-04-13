using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private static Color color;

    public static Color Color { get => color; private set => color = value; }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
            Color = new Color(Random.value, Random.value, Random.value);
    }
}