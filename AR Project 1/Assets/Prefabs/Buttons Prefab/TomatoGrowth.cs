using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoGrowth : MonoBehaviour
{
    public GameObject TDirt;
    public GameObject TomatoSprout;
    public GameObject Tomato;
    private  GameObject newTomato;
    void Start()
    {
       

    }
    public void Begin()
    {
        StartCoroutine(SproutT());
    }

    private void OnDisable()
    {
        StopCoroutine(SproutT());
    }

    IEnumerator SproutT(float countTime = 1f)
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
               newTomato = Instantiate(TDirt);
            }
            if (count == 10)
            {
                Debug.Log("Sprouted");
               newTomato.transform.GetChild(1).gameObject.SetActive(true);
            }
            if (count == 20)
            {

                newTomato.transform.GetChild(1).gameObject.SetActive(false);
                newTomato.transform.GetChild(0).gameObject.SetActive(true);


                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
