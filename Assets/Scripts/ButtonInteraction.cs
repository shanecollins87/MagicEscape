using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonInteraction : MonoBehaviour
{

    public TextMeshProUGUI simpleUIText; 

    public void OnMainMenuButtonClicked()
    {
        simpleUIText.text = "Loading Main Menu...";
    }

    public void OnMainCreditsButtonClicked()
    {
        simpleUIText.text = "Loading Credits Menu...";
    }


    public void OnMainScoreButtonClicked()
    {
        simpleUIText.text = "Beginning Experience...";
    }


}
