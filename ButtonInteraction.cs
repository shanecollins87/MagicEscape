using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteraction : MonoBehaviour
{

    public TextMeshProUGUI simpleUIText; 

    public void OnButton1Clicked()
    {
        simpleUIText.text = "Loading Main Menu...";
    }

    public void OnButton2Clicked()
    {
        simpleUIText.text = "Loading Sonic Bells...";
    }


    public void OnButton3Clicked()
    {
        simpleUIText.text = "Loading CampFire...";
    }


}
