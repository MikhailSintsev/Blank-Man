using UnityEngine;

public class Cube : MonoBehaviour
{
    private Renderer cubeColor;

    void Start()
    {
        cubeColor = GetComponent<Renderer>();
    }

    void Update()
    {
        if (transform.position.y < -500)
            Destroy(gameObject);

        if (Input.GetKeyDown(KeyCode.I))
            cubeColor.material.color = new Color(Random.value, Random.value, Random.value);

        if (Input.GetKeyDown(KeyCode.O))
            cubeColor.material.color = ColorChanger.Color;
    }
}