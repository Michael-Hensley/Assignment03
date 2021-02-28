using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField nameInput;
    public static string frogName = "Pepe";

    public void setFrogName()
    {
        frogName = nameInput.text.ToString();
        Debug.Log(frogName);
    }

}
