using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggplantGrowth : MonoBehaviour
{



    public GameObject EDirt;
    public GameObject EggplantSprout;
    public GameObject Eggplant;
    public Transform DirtPlace;
    public Transform SproutPlace;
    public Transform CarrotPos;

    void Start()
    {


    }
    public void Begin()
    {
        StartCoroutine(SproutE());
    }

    private void OnDisable()
    {
        StopCoroutine(SproutE());
    }

    IEnumerator SproutE(float countTime = 1f)
    {
        int count = 0;
        while (count < 20)
        {
            yield return new WaitForSeconds(countTime);
            count++;
            Debug.Log(count);
            if (count == 10)
            {
                Debug.Log("Sprouted");
                Instantiate(EggplantSprout);
                SproutPlace.position = DirtPlace.position;


            }
            if (count == 20)
            {

                Instantiate(Eggplant);
                CarrotPos.position = DirtPlace.position;
                DestroyImmediate(EggplantSprout);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
