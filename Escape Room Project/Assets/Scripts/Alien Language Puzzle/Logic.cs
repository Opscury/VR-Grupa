using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Logic : MonoBehaviour
{
    public bool slot1 = false;
    public bool slot2 = false;
    public bool slot3 = false;
    public bool slot4 = false;
    public bool slot5 = false;
    public bool slot6 = false;

    public TextMeshProUGUI screen;

    private void Update()
    {
        if(slot1 == true && slot2 == true && slot3 == true && slot4 == true && slot5 == true && slot6 == true)
        {
            screen.GetComponent<TextMeshProUGUI>().color = Color.green;
            screen.GetComponent<TextMeshProUGUI>().SetText("V");
        }
    }
}
