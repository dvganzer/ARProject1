using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornButton : MonoBehaviour
{
    public GameObject prefab;

    public void Instantiate()
    {
        Instantiate(prefab);
    }
}
