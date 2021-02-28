using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showName : MonoBehaviour
{
    public Text nameTXTbox;
    void Start()
    {
        nameTXTbox.text = "Frog " + InputName.frogName;
    }
}
