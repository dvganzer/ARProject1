using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornGrowth : MonoBehaviour
{
    public GameObject CDirt;
    public GameObject CornSprout;
    public GameObject Corn;
    public Transform DirtPlace;
    public Transform SproutPlace;

    void Start()
    {


    }
    public void Begin()
    {
        StartCoroutine(SproutC());
    }

    private void OnDisable()
    {
        StopCoroutine(SproutC());
    }

    IEnumerator SproutC(float countTime = 1f)
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
                Instantiate(CornSprout, DirtPlace.position, DirtPlace.rotation);
                Destroy(CDirt);


            }
            if (count == 20)
            {

                Destroy(CornSprout, 1);
                Debug.Log("Collect!");

                Instantiate(Corn, SproutPlace.position, SproutPlace.rotation);
            }
        }
        OnDisable();
    }
}
