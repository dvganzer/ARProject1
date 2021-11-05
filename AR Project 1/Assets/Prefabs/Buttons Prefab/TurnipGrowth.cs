using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnipGrowth : MonoBehaviour
{

    public GameObject TuDirt;
    public GameObject TurnipSprout;
    public GameObject Turnip;
    public Transform DirtPlace;
    public Transform SproutPlace;
    public Transform CarrotPos;

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
            if (count == 10)
            {
                Debug.Log("Sprouted");
                Instantiate(TurnipSprout);
                SproutPlace.position = DirtPlace.position;

            }
            if (count == 20)
            {

                Instantiate(Turnip);
                CarrotPos.position = DirtPlace.position;
                DestroyImmediate(TurnipSprout);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
