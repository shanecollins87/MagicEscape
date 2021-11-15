//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

////https://youtu.be/eL_zHQEju8s
//// I followed this tutorial

//public class WaveManager : MonoBehaviour
//{

//    public static WaveManager instance;  // Singleton

//    public float amplitude = 1f;
//    public float lenght = 2f;
//    public float speed = 1f;
//    public float offset = 0f;

//    private void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//        }
//        else if (instance != this)
//        {
//            Debug.Log("Instance already exists, destroying object!");
//            Destroy(this);

//        }
//    }

//    private void Update()
//    {
//        offset += Time.deltaTime * speed;
//    }

//    public float GetWaveHeight(float _x)
//    {
//        return amplitude * Mathf.Sin(_x / length + offset);
//    }
//}
//}





