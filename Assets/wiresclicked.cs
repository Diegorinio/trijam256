using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wiresclicked : MonoBehaviour
{
    public bool clickedred1 = false;
    public bool clickedred2 = false;

    public bool yellowclicked1 = false;
    public bool yellowclicked2 = false;

    public bool greenclicked1 = false;
    public bool greenclicked2 = false;

    public bool blueclicked1 = false;
    public bool blueclicked2 = false;

    public bool linked1 = false;
    public bool linked2 = false;
    public bool linked3 = false;
    public bool linked4 = false;
    //cable
    GameObject cablered;
    GameObject cablegreen;
    GameObject cableblue;
    GameObject calbeyellow;
    GameObject slider;

    void Start()
    {
        cablered = GameObject.Find("redcable");
        cablegreen = GameObject.Find("greencabl");
        cableblue= GameObject.Find("bluecable");
        calbeyellow = GameObject.Find("yellowcable");
        cablered.SetActive(false);
        cablegreen.SetActive(false);
        cableblue.SetActive(false);
        calbeyellow.SetActive(false);
        slider = GameObject.Find("Slider");

    }
    public float timeRemaining = 3;

    private void Update()
    {
        if (clickedred1 && clickedred2)
        {
            linked1 = true;
            cablered.SetActive(true);

        }


        if (yellowclicked1&& yellowclicked2)
            {
            linked2 = true;
            calbeyellow.SetActive(true);
            }
        if(greenclicked1 && greenclicked2)
        {
            linked3 = true;
            cablegreen.SetActive(true);
        }
        if(blueclicked1 && blueclicked2)
        {
            linked4 = true;
            cableblue.SetActive(true);
        }

        if (linked1&&linked2&&linked3&&linked4) {
            gamecompleted();
        }
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            slider.GetComponent<Slider>().value = timeRemaining;
            if(timeRemaining <= 0)
            {
                gamefailed();
            }
        }
    }
    void gamecompleted()
    {
        print("udalo ci sie");
    }
    void gamefailed()
    {

    }
    public void red1Clicked()
    {
        clickedred1 = true;
    }
    public void red2Clicked()
    {
        clickedred2 = true;
    }
    public void yellow1clicked() 
    {
        yellowclicked1 = true;

    }
    public void yellow2clicked()
    {
        yellowclicked2 = true;
    }
    public void green1Clicked()
    {
        greenclicked1 = true;
    }
    public void green2Clicked()
    {
        greenclicked2 = true;
    }
    public void blue1clicked()
    {
        blueclicked1 = true;
    }
    public void blue2Clicked()
    {
        blueclicked2 = true;
    }


}
