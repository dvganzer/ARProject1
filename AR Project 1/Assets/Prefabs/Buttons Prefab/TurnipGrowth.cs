using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipGrowth : MonoBehaviour
{

    public GameObject TuDirt;
    public GameObject TurnipSprout;
    public GameObject Turnip;
    public Transform DirtPlace;
    public Transform SproutPlace;

    void Start()
    {


    }
    public void Begin()
    {
        StartCoroutine(SproutTu());
    }

    private void OnDisable()
    {
        StopCoroutine(SproutTu());
    }

    IEnumerator SproutTu(float countTime = 1f)
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
                Instantiate(TurnipSprout, DirtPlace.position, DirtPlace.rotation);
                Destroy(TuDirt);


            }
            if (count == 20)
            {

                Destroy(TurnipSprout,1);              
                Debug.Log("Collect!");
                
                Instantiate(Turnip, SproutPlace.position, SproutPlace.rotation);
            }
        }
        OnDisable();
    }
}
