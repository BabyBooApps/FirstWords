using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordObj : MonoBehaviour
{
    public string Id;

    public void SetObj(string id, Sprite sp)
    {
        Id = id;
        GetComponent<SpriteRenderer>().sprite = sp;
    }



    private void OnMouseDown()
    {
        AudioManager.instance.Play_Alphabet_Clip(Id);
        iTween.PunchScale(this.gameObject,new  Vector3(1.1f, 1.1f, 1.1f), 0.5f);
    }
}
