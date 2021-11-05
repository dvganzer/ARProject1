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
                Instantiate(EggplantSprout, DirtPlace.position, DirtPlace.rotation);
                Destroy(EDirt);


            }
            if (count == 20)
            {

                Destroy(EggplantSprout, 1);
                Debug.Log("Collect!");

                Instantiate(Eggplant, SproutPlace.position, SproutPlace.rotation);
            }
        }
        OnDisable();
    }
}
