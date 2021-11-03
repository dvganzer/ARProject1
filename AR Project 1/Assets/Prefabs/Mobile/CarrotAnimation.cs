using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrotAnimation : MonoBehaviour
{
    private float startTime;
    public GameObject CarrotSprout;
    public Button Carot_Button;


    private void Start()
    {
        Button btn = Carot_Button .GetComponent<Button>();
        btn.onClick.AddListener(TaskOnCarrotClick);
    }
    void Update()
    {

       
    }
    void TaskOnCarrotClick()
    {
        Debug.Log("You have clicked the carrot button!");
        float t = Time.time - startTime;
        Debug.Log(t);

        if (t == 10)
        {
            Destroy(this);
            Instantiate(CarrotSprout);
            Debug.Log("Sprouted");
        }
    }
}
