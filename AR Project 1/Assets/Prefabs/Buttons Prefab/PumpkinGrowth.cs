using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinGrowth : MonoBehaviour
{
    public GameObject PDirt;
    public GameObject PumpkinSprout;
    public GameObject Pumpkin;
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
                PumpkinSprout.SetActive(true);
               


            }
            if (count == 20)
            {
                PumpkinSprout.SetActive(false);
                Pumpkin.SetActive(true);
              
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
