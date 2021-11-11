using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject CDirt;
    public GameObject CornSprout;
    public GameObject Corn;
    private GameObject newCorn;


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
            if (count == 1)
            {
                Debug.Log("Planted");
                newCorn = Instantiate(CDirt);
            }
            if (count == 10)
            {
                Debug.Log("Sprouted");
                newCorn.transform.GetChild(1).gameObject.SetActive(true);



            }
            if (count == 20)
            {

                newCorn.transform.GetChild(1).gameObject.SetActive(false);
                newCorn.transform.GetChild(0).gameObject.SetActive(true);
                Debug.Log("Collect!");
            }
        }
        OnDisable();
    }
}
