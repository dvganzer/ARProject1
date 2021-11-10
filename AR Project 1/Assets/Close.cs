using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Close : MonoBehaviour
{
    public GameObject openBs;
    public GameObject openB;
    public GameObject closeB;
    public GameObject btns;
  public void Open()
    {
        openBs.SetActive(false);
        openB.SetActive(false);
        closeB.SetActive(true);
        btns.SetActive(true);
    }
    public void Closed()
    {
        openBs.SetActive(true);
        openB.SetActive(true);
        closeB.SetActive(false);
        btns.SetActive(false);
    }

}
