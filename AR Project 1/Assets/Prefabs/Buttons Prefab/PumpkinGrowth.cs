using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinGrowth : MonoBehaviour
{

 

    public GameObject PDirt;
    public GameObject PumpkinSprout;
    public GameObject Pumpkin;
    public Transform DirtPlace;
    public Transform SproutPlace;

    void Start()
    {


    }
    public void Begin()
    {
        StartCoroutine(SproutP());
    }

    private void OnDisable()
    {
        StopCoroutine(SproutP());
    }

    IEnumerator SproutP(float countTime = 1f)
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
                Instantiate(PumpkinSprout, DirtPlace.position, DirtPlace.rotation);
                Destroy(PDirt);


            }
            if (count == 20)
            {

                Destroy(PumpkinSprout, 1);
                Debug.Log("Collect!");

                Instantiate(Pumpkin, SproutPlace.position, SproutPlace.rotation);
            }
        }
        OnDisable();
    }
}
