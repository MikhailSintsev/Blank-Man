using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private static Color color;
    public static Color Color { get => color; private set => color = value; }

    // Каждый кадр генерировать случайный цвет и записывать в static переменную color
    private void Update()
    {
        color = new Color(Random.value, Random.value, Random.value);
    }
}