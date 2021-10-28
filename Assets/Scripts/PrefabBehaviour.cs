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
        if (transform.position.y < -500)
            Destroy(gameObject);

        if (Input.GetKeyDown(KeyCode.I))
            prefabColor.material.color = new Color(Random.value, Random.value, Random.value);

        if (Input.GetKeyDown(KeyCode.O))
            prefabColor.material.color = ColorChanger.Color;

        if (Input.GetKeyDown(KeyCode.G))
            prefabRigidbody.useGravity = !prefabRigidbody.useGravity;
    }
}