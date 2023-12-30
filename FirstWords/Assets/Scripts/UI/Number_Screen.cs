using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number_Screen : MonoBehaviour
{
    public Button NextBtn;
    public Button PreviousBtn;
    public Button HomeBtn;

    public void Set_NextBtn(bool isActive)
    {
        NextBtn.gameObject.SetActive(isActive);
    }

    public void Set_PrevBtn(bool isActive)
    {
        PreviousBtn.gameObject.SetActive(isActive);
    }
}
