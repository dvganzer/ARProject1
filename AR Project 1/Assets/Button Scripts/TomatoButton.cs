using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoButton : MonoBehaviour
{
    public GameObject prefab;
    public Transform prefabpos;
    public bool on;



    public void Instantiate()
    {
        prefab.SetActive(true);
        Instantiate(prefab);
        prefabpos.position = Vector3.forward * 2f;
        on = false;
     
    }
}
