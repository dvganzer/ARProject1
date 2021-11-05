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
    public Transform CarrotPos;

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
                Instantiate(TomatoSprout);
                SproutPlace.position = DirtPlace.position;


            }
            if (count == 20)
            {

                Instantiate(Tomato);
                CarrotPos.position = DirtPlace.position;
                DestroyImmediate(TomatoSprout);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
