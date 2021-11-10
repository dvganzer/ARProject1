using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornGrowth : MonoBehaviour
{
    public GameObject CDirt;
    public GameObject CornSprout;
    public GameObject Corn;


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
                CornSprout.SetActive(true);



            }
            if (count == 20)
            {

                CornSprout.SetActive(false);
                Corn.SetActive(true);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
