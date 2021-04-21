using UnityEngine;

public class Cube : MonoBehaviour
{
    private Renderer cubeColor;
    private Rigidbody cubeRigidbody;

    void Start()
    {
        cubeColor = GetComponent<Renderer>();
        cubeRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -500)
            Destroy(gameObject);

        if (Input.GetKeyDown(KeyCode.I))
            cubeColor.material.color = new Color(Random.value, Random.value, Random.value);

        if (Input.GetKeyDown(KeyCode.O))
            cubeColor.material.color = ColorChanger.Color;

        if (Input.GetKeyDown(KeyCode.G))
            cubeRigidbody.useGravity = !cubeRigidbody.useGravity;
    }
}