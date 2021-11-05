using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoGrowth : MonoBehaviour
{

  

    public GameObject TDirt;
    public GameObject TomatoSprout;
    public GameObject Tomato;
    public Transform DirtPlace;
    public Transform SproutPlace;

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
            if (count == 10)
            {
                Debug.Log("Sprouted");
                Instantiate(TomatoSprout, DirtPlace.position, DirtPlace.rotation);
                Destroy(TDirt);


            }
            if (count == 20)
            {

                Destroy(TomatoSprout, 1);
                Debug.Log("Collect!");

                Instantiate(Tomato, SproutPlace.position, SproutPlace.rotation);
            }
        }
        OnDisable();
    }
}
