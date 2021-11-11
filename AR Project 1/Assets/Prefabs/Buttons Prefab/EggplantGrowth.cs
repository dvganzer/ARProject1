using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggplantGrowth : MonoBehaviour
{
    public GameObject EDirt;
    public GameObject EggplantSprout;
    public GameObject Eggplant;
    private GameObject newEggplant;
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
            if (count == 1)
            {
                Debug.Log("Planted");
                newEggplant = Instantiate(EDirt);
            }
            if (count == 10)
            {
                Debug.Log("Sprouted");
                newEggplant.transform.GetChild(1).gameObject.SetActive(true);
            }
            if (count == 20)
            {

                newEggplant.transform.GetChild(1).gameObject.SetActive(false);
                newEggplant.transform.GetChild(0).gameObject.SetActive(true);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
