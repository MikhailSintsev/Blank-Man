using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private static Color color;
    public static Color Color { get => color; private set => color = value; }

    // ������ ���� ������������ ��������� ���� � ���������� � static ���������� color
    private void Update()
    {
        color = new Color(Random.value, Random.value, Random.value);
    }
}