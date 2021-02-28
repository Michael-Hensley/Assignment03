using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownLives : MonoBehaviour
{
    public Dropdown frogLives;
    public static int numLives = 1;
    public void selectLives()
    {
        switch (frogLives.value)
        {

            case 0:
            numLives = 1;
            Debug.Log(numLives);
            break;

            case 1:
            numLives = 2;
            Debug.Log(numLives);
            break;

            case 2:
            numLives = 3;
            Debug.Log(numLives);
            break;

            default:
            numLives = 1;
            Debug.Log(numLives);
            break;


        }
    }
}
