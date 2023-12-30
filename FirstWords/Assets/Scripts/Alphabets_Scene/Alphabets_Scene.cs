using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Alphabets_Scene : MonoBehaviour
{
    public int LevelId;

    public WordObj AlphabetContainer;
    public List<Word_Obj> words_List = new List<Word_Obj>();
    public Word_Obj currentWord;
    public int id = 0;

    public TextMeshPro NameObj;

    // Start is called before the first frame update
    void Start()
    {
        SetWords_List();
        InitalizeLevel();
    }

    public void SetWords_List()
    {
        if(LevelId == 1)
        {
            words_List = GameData.instance.Alphabet_List;
        }else if(LevelId == 2)
        {
            words_List = GameData.instance.Number_List;
        }
       
    }

    public void InitalizeLevel()
    {
         id = 0;
        Set_Alphabet_Container(words_List[id]);
        StartCoroutine(Activate_Alphabet());
      
    }
    public void SetNextAlphabet()
    {
        id++;
        if(id < words_List.Count)
        {
            Set_Alphabet_Container(words_List[id]);
            StartCoroutine(Activate_Alphabet());
            
            
        }
        else
        {
            id--;
        }
       
    }

    public void SetPrevAlphabet()
    {
        id--;
        if (id >= 0)
        {
            Set_Alphabet_Container(words_List[id]);
            StartCoroutine(Activate_Alphabet());
           
        }
        else
        {
            id++;
        }
       
    }
    public void Set_Alphabet_Container(Word_Obj obj)
    {
        AlphabetContainer.SetObj(obj.Id, obj.Image);
      
    }

    public void Set_Nex_Prev_Btns()
    {
        if(id <= 0)
        {
            if (LevelId == 1)
            {
                UI_Manager.instance.alphabet_Screen.Set_PrevBtn(false);
                UI_Manager.instance.alphabet_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 2)
            {
                UI_Manager.instance.number_Screen.Set_PrevBtn(false);
                UI_Manager.instance.number_Screen.Set_NextBtn(true);
            }

            
        }else if(id >= words_List.Count -1)
        {
            if (LevelId == 1)
            {
                UI_Manager.instance.alphabet_Screen.Set_PrevBtn(true);
                UI_Manager.instance.alphabet_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 2)
            {
                UI_Manager.instance.number_Screen.Set_PrevBtn(true);
                UI_Manager.instance.number_Screen.Set_NextBtn(false);
            }

        }else
        {

            if (LevelId == 1)
            {
                UI_Manager.instance.alphabet_Screen.Set_PrevBtn(true);
                UI_Manager.instance.alphabet_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 2)
            {
                UI_Manager.instance.number_Screen.Set_PrevBtn(true);
                UI_Manager.instance.number_Screen.Set_NextBtn(true);
            }
        }
    }

    public IEnumerator Activate_Alphabet()
    {
        AudioManager.instance.Play_MoveClip();

        if(LevelId == 1)
        {
            UI_Manager.instance.alphabet_Screen.Set_PrevBtn(false);
            UI_Manager.instance.alphabet_Screen.Set_NextBtn(false);
        }else if (LevelId == 2)
        {
            UI_Manager.instance.number_Screen.Set_PrevBtn(false);
            UI_Manager.instance.number_Screen.Set_NextBtn(false);
        }


        AlphabetContainer.gameObject.transform.localScale = Vector3.zero;
       /* Color col = AlphabetContainer.color;
        AlphabetContainer.color = new Color(Color.a , col)*/

        iTween.ScaleTo(AlphabetContainer.gameObject, iTween.Hash(
                    "scale", new Vector3(1.3f, 1.3f, 1.3f),
                    "time", 0.5f,
                    "easetype", iTween.EaseType.easeInQuint
                ));

     

        yield return new WaitForSeconds(0.5f);

        Set_Nex_Prev_Btns();

        AudioManager.instance.Play_Alphabet_Clip(words_List[id].Id);

        SetName(words_List[id].Name);
    }

    public void SetName(string name)
    {
        NameObj.text = name;
    }

    public void Play_Word_Audio_On_Click()
    {

    }

    


}
