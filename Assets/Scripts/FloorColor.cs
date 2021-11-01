using UnityEngine;

public class FloorColor : MonoBehaviour
{
    private Renderer _floorColor;

    private void Start()
    {
        _floorColor = GetComponent<Renderer>();
    }

    private void Update()
    {
        //  При нажатии клавиши "C" поменять цвет объекта на случайный.
        if (Input.GetKeyDown(KeyCode.C))
            _floorColor.material.color = new Color(Random.value, Random.value, Random.value);

        //  При нажатии клавиши "R" включать/выключать отбрасывание тени на объект.
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    if (_floorColor.receiveShadows == true)
        //        _floorColor.receiveShadows = false;
        //    else if (_floorColor.receiveShadows == false)
        //        _floorColor.receiveShadows = true;
        //}
    }
}
