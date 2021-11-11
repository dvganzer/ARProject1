using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinGrowth : MonoBehaviour
{
    public GameObject PDirt;
    public GameObject PumpkinSprout;
    public GameObject Pumpkin;
    private GameObject newPumpkin;
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
            if (count == 1)
            {
                Debug.Log("Planted");
                newPumpkin = Instantiate(PDirt);
            }
            if (count == 10)
            {
                newPumpkin.transform.GetChild(1).gameObject.SetActive(true);



            }
            if (count == 20)
            {
                newPumpkin.transform.GetChild(1).gameObject.SetActive(false);
                newPumpkin.transform.GetChild(0).gameObject.SetActive(true);

                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
