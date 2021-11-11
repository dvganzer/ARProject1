using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipGrowth : MonoBehaviour
{

    public GameObject TuDirt;
    public GameObject TurnipSprout;
    public GameObject Turnip;
    private GameObject newTurnip;
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
            if (count == 1)
            {
                Debug.Log("Planted");
                newTurnip = Instantiate(TuDirt);
            }
            if (count == 10)
            {
                Debug.Log("Sprouted");
                newTurnip.transform.GetChild(1).gameObject.SetActive(true);


            }
            if (count == 20)
            {

                newTurnip.transform.GetChild(1).gameObject.SetActive(false);
                newTurnip.transform.GetChild(0).gameObject.SetActive(true);

                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
