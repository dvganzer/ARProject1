using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipGrowth : MonoBehaviour
{

    public GameObject TuDirt;
    public GameObject TurnipSprout;
    public GameObject Turnip;
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
                TurnipSprout.SetActive(true);
                

            }
            if (count == 20)
            {

                TurnipSprout.SetActive(false);
                Turnip.SetActive(true);
              
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
