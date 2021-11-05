using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinButton : MonoBehaviour
{
    public GameObject prefab;
    public Transform prefabpos;

    public void Instantiate()
    {
        Instantiate(prefab);
        prefabpos.position = Vector3.forward * 2f;
    }
}
