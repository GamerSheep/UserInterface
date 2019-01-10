using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonToggle : MonoBehaviour
{
    
    public void ToggleButtons(bool state)
    {
        GetComponent<Button>().interactable = state;
    }


}
