using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggplantGrowth : MonoBehaviour
{
    public GameObject EDirt;
    public GameObject EggplantSprout;
    public GameObject Eggplant;
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
                EggplantSprout.SetActive(true);
            }
            if (count == 20)
            {

                EggplantSprout.SetActive(false);
                Eggplant.SetActive(true);         
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
