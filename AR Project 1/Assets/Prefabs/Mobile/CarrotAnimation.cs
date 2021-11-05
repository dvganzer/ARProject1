using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarrotAnimation : MonoBehaviour
{
    private float startTime;
    public GameObject CarrotSprout;
    public GameObject CornSprout;
    public GameObject EggplantSprout;
    public GameObject PumpkinSprout;
    public GameObject TomatoSprout;
    public GameObject TurnipSprout;

    public Button Carrot_Button;
    public Button Corn_Button;
    public Button Eggplant_Button;
    public Button Pumpkin_Button;
    public Button Tomato_Button;
    public Button Turnip_Button;


    private void Start()
    {
        startTime = Time.time;

        Button Cbtn = Carrot_Button .GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnCarrotClick);

        Button Cobtn = Corn_Button.GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnCornClick);

        Button Ebtn = Eggplant_Button.GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnEggplantClick);

        Button Pbtn = Pumpkin_Button.GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnPumpkinClick);

        Button Tbtn = Tomato_Button.GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnTomatoClick);

        Button Tubtn = Turnip_Button.GetComponent<Button>();
        Cbtn.onClick.AddListener(TaskOnTurnipClick);
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
    void TaskOnCornClick()
    {
        Debug.Log("You have clicked the carrot button!");
        float t = Time.time - startTime;
        Debug.Log(t);

        if (t == 10)
        {
            Destroy(this);
            Instantiate(CornSprout);
            Debug.Log("Sprouted");
        }
    }
    void TaskOnEggplantClick()
    {
        Debug.Log("You have clicked the carrot button!");
        float t = Time.time - startTime;
        Debug.Log(t);

        if (t == 10)
        {
            Destroy(this);
            Instantiate(EggplantSprout);
            Debug.Log("Sprouted");
        }
    }
    void TaskOnPumpkinClick()
    {
        Debug.Log("You have clicked the carrot button!");
        float t = Time.time - startTime;
        Debug.Log(t);

        if (t == 10)
        {
            Destroy(this);
            Instantiate(PumpkinSprout);
            Debug.Log("Sprouted");
        }
    }void TaskOnTomatoClick()
    {
        Debug.Log("You have clicked the carrot button!");
        float t = Time.time - startTime;
        Debug.Log(t);

        if (t == 10)
        {
            Destroy(this);
            Instantiate(TomatoSprout);
            Debug.Log("Sprouted");
        }
    }
    void TaskOnTurnipClick()
    {
        Debug.Log("You have clicked the carrot button!");
        float t = Time.time - startTime;
        Debug.Log(t);

        if (t == 10)
        {
            Destroy(this);
            Instantiate(TurnipSprout);
            Debug.Log("Sprouted");
        }
    }
}
