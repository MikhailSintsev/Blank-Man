﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubePrefab : MonoBehaviour
{
    //
    
    //  Назначение : 
    // Спавнить префабы в ряд по оси X до достижения их максимального количества в ряде,
    // затем сместить позицию спавна по оси Z и начать новый ряд.
    //
    //  Принцип действия : 
    // При нажатии клавиш "P" или "U" заспавнится префаб ("P" - один префаб, "U" - бесконечный спавн при 
    // удержании клавишы) на позиции "pos", которая задается стартовой точкой "startPoint". 
    // Каждый последующий префаб спавнится со смещением "offset" по оси X.
    // При достижении количества "maxCount" заспавненых префабов в ряде, произойдет смещение по оси Z, 
    // при этом координате "pos.x" вернется стартовое значение ("startPoint.x").

    [SerializeField] private Vector3 pos;
    [SerializeField] private int count = 0;


    public GameObject cubePrefab;
    public Vector3 startPoint;
    public float offset = 1;
    public int maxCount = 10;
    public Transform cubePrefabParent;

    private void Start()
    {
        pos = startPoint;
    }

    private void Update()
    {        
        //  Спавнится один префаб за одно нажатие клавиши.
        if (Input.GetKeyDown(KeyCode.P))
        {            
            if (count < maxCount)
            {
                SpawnPrefab();                
            }
            else
            {
                count = 0;
                pos.x = startPoint.x;
                pos.z += offset;                
                SpawnPrefab();
            }
        }

        //  Бесконечный спавн префабов при зажатой клавише.
        if (Input.GetKey(KeyCode.U))
        {
            if (count < maxCount)
            {
                SpawnPrefab();
            }
            else
            {
                count = 0;
                pos.x = startPoint.x;
                pos.z += offset;
                SpawnPrefab();
            }
        }
    }

    void SpawnPrefab()
    {
        Instantiate(cubePrefab, pos, Quaternion.identity, cubePrefabParent);
        count++;
        pos.x += offset;
    }
}
