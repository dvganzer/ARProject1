using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{
    public Text Money;
    private int Coin;

    void Start()
    {
       
    }
    private void Update()
    {
        Money.text = Coin.ToString();
    }

    public void Collected()
    {
        if (gameObject.tag == "Grown")
        {
            gameObject.SetActive(false);
            Coin += 5;
            Debug.Log("Money");

        }
    }
}
