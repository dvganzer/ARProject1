using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotGrowth : MonoBehaviour
{
    public GameObject Dirt;
    public GameObject CarrotSprout;
    public GameObject Carrot;
    private GameObject newCarrot;

    void Start()
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
        
            int count = 0;
            while (count < 20)
            {
                yield return new WaitForSeconds(countTime);
                count++;
                Debug.Log(count);
                if (count == 1)
                {
                    Debug.Log("Planted");
                    
                }
                if (count == 10)
                {

                    Debug.Log("Sprouted");
                    newCarrot.transform.GetChild(1).gameObject.SetActive(true);



                }
                if (count == 20)
                {
                    newCarrot.transform.GetChild(1).gameObject.SetActive(false);
                    newCarrot.transform.GetChild(0).gameObject.SetActive(true);

                    Debug.Log("Collect!");


                }
            }
           
            OnDisable();

        


        
    }

}

