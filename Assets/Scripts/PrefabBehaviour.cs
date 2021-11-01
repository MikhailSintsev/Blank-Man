using UnityEngine;

public class PrefabBehaviour : MonoBehaviour
{
    private Renderer prefabColor;
    private Rigidbody prefabRigidbody;

    void Start()
    {
        prefabColor = GetComponent<Renderer>();
        prefabRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Уничтожить объект, если он ниже определенной координаты по оси Y
        if (transform.position.y < -500)
            Destroy(gameObject);

        // Сгенерировать цвет и присвоить одному объекту (каждому объекту генерируется свой цвет)
        if (Input.GetKeyDown(KeyCode.I))
            prefabColor.material.color = new Color(Random.value, Random.value, Random.value);

        // Присвоить цвет из статичной переменной color всем объектам
        if (Input.GetKeyDown(KeyCode.O))
            prefabColor.material.color = ColorChanger.Color;

        // Переключить bool useGravity в Rigidbody объекта
        if (Input.GetKeyDown(KeyCode.G))
            prefabRigidbody.useGravity = !prefabRigidbody.useGravity;
    }
}