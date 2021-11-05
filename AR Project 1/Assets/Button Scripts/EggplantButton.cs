using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggplantButton : MonoBehaviour
{
    public GameObject prefab;

    public void Instantiate()
    {
        Instantiate(prefab);
    }
}
