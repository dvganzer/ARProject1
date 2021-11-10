using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotGrowth : MonoBehaviour
{
    public GameObject Dirt;
    public GameObject CarrotSprout;
    public GameObject Carrot;

    void Start()
    {
        CarrotSprout.SetActive(false);
        Carrot.SetActive(false);

    }
    private void Update()
    {
        
    }
    public void Begin()
    {

        StartCoroutine(Sprout());
    }

    private void OnDisable()
    {
        StopCoroutine(Sprout());
    }

    IEnumerator Sprout(float countTime = 1f)
    {
        if (Dirt.tag == "CarrotDirt(All)(Clone)")
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
                    CarrotSprout.SetActive(true);



                }
                if (count == 20)
                {
                    CarrotSprout.SetActive(false);
                    Carrot.SetActive(true);

                    Debug.Log("Collect!");


                }
            }
            OnDisable();
        }


        
    }

}

