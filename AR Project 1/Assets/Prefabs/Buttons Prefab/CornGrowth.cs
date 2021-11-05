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
    public Transform CarrotPos;

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
                Instantiate(CornSprout);
                SproutPlace.position = DirtPlace.position;
              


            }
            if (count == 20)
            {

                Instantiate(Corn);
                CarrotPos.position = DirtPlace.position;
                DestroyImmediate(CornSprout);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
