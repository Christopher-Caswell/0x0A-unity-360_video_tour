using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textPanel : MonoBehaviour
{
    public GameObject text;

    public void toggleText()
    {
        if (text.activeSelf)
        {
            text.SetActive(false);
        }
        else
        {
            text.SetActive(true);
        }
    }
}
