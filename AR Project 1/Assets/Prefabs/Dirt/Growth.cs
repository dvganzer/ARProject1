using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Growth : MonoBehaviour
{
    public GameObject TDirt;
    public GameObject TomatoSprout;
    public GameObject Tomato;
    private GameObject newTomato;
    private float timeLeft;
    private bool keepTimer;
    public Text Money;
    private int Coin;

    void Start()
    {
        TDirt.transform.GetChild(1).gameObject.SetActive(false);
        TDirt.transform.GetChild(0).gameObject.SetActive(false);

    }
    public void Update()
    {

        if (TDirt.activeSelf)
        {
            timeLeft += Time.deltaTime;
            int seconds = (int)timeLeft % 60;
            



            if (seconds == 10)
            {
                Debug.Log("Sprouted");
                TDirt.transform.GetChild(1).gameObject.SetActive(true);
            }
            if (seconds == 20)
            {
                TDirt.transform.GetChild(1).gameObject.SetActive(false);
                TDirt.transform.GetChild(0).gameObject.SetActive(true);
                Debug.Log("Collect!");
            }
            if (seconds == 30)
            {
                TDirt.transform.GetChild(1).gameObject.SetActive(false);
                TDirt.transform.GetChild(0).gameObject.SetActive(false);
                TDirt.SetActive(false);
                Debug.Log("Old");

            }
            else
            {
                seconds = 0;
            }
        }

    }
}
