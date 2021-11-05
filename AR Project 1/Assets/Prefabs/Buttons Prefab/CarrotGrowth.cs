using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotGrowth : MonoBehaviour
{
    public GameObject Dirt;
    public GameObject CarrotSprout;
    public GameObject Carrot;
    public Transform DirtPlace;
    public Transform SproutPlace;

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
            if (count == 10)
            {
                Debug.Log("Sprouted");
                Instantiate(CarrotSprout, DirtPlace.position, DirtPlace.rotation);
                Destroy(Dirt);


            }
            if (count == 20)
            {

                Destroy(CarrotSprout, 1);
                Debug.Log("Collect!");

                Instantiate(Carrot, SproutPlace.position, SproutPlace.rotation);
            }
        }
        OnDisable();
    }

}

