using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private static Color color;
    public static Color Color { get => color; private set => color = value; }


    private void Update()
    {
        Color = new Color(Random.value, Random.value, Random.value);
    }
}