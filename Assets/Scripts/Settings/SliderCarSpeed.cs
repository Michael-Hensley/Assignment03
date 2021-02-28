using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCarSpeed : MonoBehaviour
{
    public Slider carSpeedSlider;
    public static int carSpeed = 8;

    public void selectSpeed()
    {
        switch (carSpeedSlider.value)
        {
            case 1:
            carSpeed = 4;
            Debug.Log(carSpeed);
            break;

            case 2:
            carSpeed = 8;
            Debug.Log(carSpeed);
            break;

            case 3:
            carSpeed = 12;
            Debug.Log(carSpeed);
            break;


        }
    }
}
