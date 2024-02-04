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
        
    }

    public void StartLevel()
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
        else if (LevelId == 3)
        {
            words_List = GameData.instance.Color_List;
        }
        else if (LevelId == 4)
        {
            words_List = GameData.instance.Animal_List;
        }
        else if (LevelId == 5)
        {
            words_List = GameData.instance.Fruits_List;
        }
        else if (LevelId == 6)
        {
            words_List = GameData.instance.Vegtable_List;
        }
        else if (LevelId == 7)
        {
            words_List = GameData.instance.Birds_List;
        }
        else if (LevelId == 8)
        {
            words_List = GameData.instance.FarmAnimals_List;
        }
        else if (LevelId == 9)
        {
            words_List = GameData.instance.SeaAnimals_List;
        }
        else if (LevelId == 10)
        {
            words_List = GameData.instance.Shapes_List;
        }
        else if (LevelId == 11)
        {
            words_List = GameData.instance.Sports_List;
        }
        else if (LevelId == 12)
        {
            words_List = GameData.instance.Vehicles_List;
        }
        else if (LevelId == 13)
        {
            words_List = GameData.instance.MusicalInstruments_List;
        }
        else if (LevelId == 14)
        {
            words_List = GameData.instance.BodyParts_List;
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
        AudioManager.instance.Play_Btn_Click();
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
        AudioManager.instance.Play_Btn_Click();
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
            else if (LevelId == 3)
            {
                UI_Manager.instance.color_Screen.Set_PrevBtn(false);
                UI_Manager.instance.color_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 4)
            {
                UI_Manager.instance.animal_Screen.Set_PrevBtn(false);
                UI_Manager.instance.animal_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 5)
            {
                UI_Manager.instance.fruit_Screen.Set_PrevBtn(false);
                UI_Manager.instance.fruit_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 6)
            {
                UI_Manager.instance.vegtable_Screen.Set_PrevBtn(false);
                UI_Manager.instance.vegtable_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 7)
            {
                UI_Manager.instance.birds_Screen.Set_PrevBtn(false);
                UI_Manager.instance.birds_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 8)
            {
                UI_Manager.instance.farmAnimals_Screen.Set_PrevBtn(false);
                UI_Manager.instance.farmAnimals_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 9)
            {
                UI_Manager.instance.seaAnimals_Screen.Set_PrevBtn(false);
                UI_Manager.instance.seaAnimals_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 10)
            {
                UI_Manager.instance.shapes_Screen.Set_PrevBtn(false);
                UI_Manager.instance.shapes_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 11)
            {
                UI_Manager.instance.sports_Screen.Set_PrevBtn(false);
                UI_Manager.instance.sports_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 12)
            {
                UI_Manager.instance.vehicles_Screen.Set_PrevBtn(false);
                UI_Manager.instance.vehicles_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 13)
            {
                UI_Manager.instance.musicalInstruments_Screen.Set_PrevBtn(false);
                UI_Manager.instance.musicalInstruments_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 14)
            {
                UI_Manager.instance.bodyParts_Screen.Set_PrevBtn(false);
                UI_Manager.instance.bodyParts_Screen.Set_NextBtn(true);
            }


        }
        else if(id >= words_List.Count -1)
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
            else if (LevelId == 3)
            {
                UI_Manager.instance.color_Screen.Set_PrevBtn(true);
                UI_Manager.instance.color_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 4)
            {
                UI_Manager.instance.animal_Screen.Set_PrevBtn(true);
                UI_Manager.instance.animal_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 5)
            {
                UI_Manager.instance.fruit_Screen.Set_PrevBtn(true);
                UI_Manager.instance.fruit_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 6)
            {
                UI_Manager.instance.vegtable_Screen.Set_PrevBtn(true);
                UI_Manager.instance.vegtable_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 7)
            {
                UI_Manager.instance.birds_Screen.Set_PrevBtn(true);
                UI_Manager.instance.birds_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 8)
            {
                UI_Manager.instance.farmAnimals_Screen.Set_PrevBtn(true);
                UI_Manager.instance.farmAnimals_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 9)
            {
                UI_Manager.instance.seaAnimals_Screen.Set_PrevBtn(true);
                UI_Manager.instance.seaAnimals_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 10)
            {
                UI_Manager.instance.shapes_Screen.Set_PrevBtn(true);
                UI_Manager.instance.shapes_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 11)
            {
                UI_Manager.instance.sports_Screen.Set_PrevBtn(true);
                UI_Manager.instance.sports_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 12)
            {
                UI_Manager.instance.vehicles_Screen.Set_PrevBtn(true);
                UI_Manager.instance.vehicles_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 13)
            {
                UI_Manager.instance.musicalInstruments_Screen.Set_PrevBtn(true);
                UI_Manager.instance.musicalInstruments_Screen.Set_NextBtn(false);
            }
            else if (LevelId == 14)
            {
                UI_Manager.instance.bodyParts_Screen.Set_PrevBtn(true);
                UI_Manager.instance.bodyParts_Screen.Set_NextBtn(false);
            }

        }
        else
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
            else if (LevelId == 3)
            {
                UI_Manager.instance.color_Screen.Set_PrevBtn(true);
                UI_Manager.instance.color_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 4)
            {
                UI_Manager.instance.animal_Screen.Set_PrevBtn(true);
                UI_Manager.instance.animal_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 5)
            {
                UI_Manager.instance.fruit_Screen.Set_PrevBtn(true);
                UI_Manager.instance.fruit_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 6)
            {
                UI_Manager.instance.vegtable_Screen.Set_PrevBtn(true);
                UI_Manager.instance.vegtable_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 7)
            {
                UI_Manager.instance.birds_Screen.Set_PrevBtn(true);
                UI_Manager.instance.birds_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 8)
            {
                UI_Manager.instance.farmAnimals_Screen.Set_PrevBtn(true);
                UI_Manager.instance.farmAnimals_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 9)
            {
                UI_Manager.instance.seaAnimals_Screen.Set_PrevBtn(true);
                UI_Manager.instance.seaAnimals_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 10)
            {
                UI_Manager.instance.shapes_Screen.Set_PrevBtn(true);
                UI_Manager.instance.shapes_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 11)
            {
                UI_Manager.instance.sports_Screen.Set_PrevBtn(true);
                UI_Manager.instance.sports_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 12)
            {
                UI_Manager.instance.vehicles_Screen.Set_PrevBtn(true);
                UI_Manager.instance.vehicles_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 13)
            {
                UI_Manager.instance.musicalInstruments_Screen.Set_PrevBtn(true);
                UI_Manager.instance.musicalInstruments_Screen.Set_NextBtn(true);
            }
            else if (LevelId == 14)
            {
                UI_Manager.instance.bodyParts_Screen.Set_PrevBtn(true);
                UI_Manager.instance.bodyParts_Screen.Set_NextBtn(true);
            }
        }
    }

    public IEnumerator Activate_Alphabet()
    {
        AudioManager.instance.Play_MoveClip();

        if (LevelId == 1)
        {
            UI_Manager.instance.alphabet_Screen.Set_PrevBtn(false);
            UI_Manager.instance.alphabet_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 2)
        {
            UI_Manager.instance.number_Screen.Set_PrevBtn(false);
            UI_Manager.instance.number_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 3)
        {
            UI_Manager.instance.color_Screen.Set_PrevBtn(false);
            UI_Manager.instance.color_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 4)
        {
            UI_Manager.instance.animal_Screen.Set_PrevBtn(false);
            UI_Manager.instance.animal_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 5)
        {
            UI_Manager.instance.fruit_Screen.Set_PrevBtn(false);
            UI_Manager.instance.fruit_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 6)
        {
            UI_Manager.instance.vegtable_Screen.Set_PrevBtn(false);
            UI_Manager.instance.vegtable_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 7)
        {
            UI_Manager.instance.birds_Screen.Set_PrevBtn(false);
            UI_Manager.instance.birds_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 8)
        {
            UI_Manager.instance.farmAnimals_Screen.Set_PrevBtn(false);
            UI_Manager.instance.farmAnimals_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 9)
        {
            UI_Manager.instance.seaAnimals_Screen.Set_PrevBtn(false);
            UI_Manager.instance.seaAnimals_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 10)
        {
            UI_Manager.instance.shapes_Screen.Set_PrevBtn(false);
            UI_Manager.instance.shapes_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 11)
        {
            UI_Manager.instance.sports_Screen.Set_PrevBtn(false);
            UI_Manager.instance.sports_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 12)
        {
            UI_Manager.instance.vehicles_Screen.Set_PrevBtn(false);
            UI_Manager.instance.vehicles_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 13)
        {
            UI_Manager.instance.musicalInstruments_Screen.Set_PrevBtn(false);
            UI_Manager.instance.musicalInstruments_Screen.Set_NextBtn(false);
        }
        else if (LevelId == 14)
        {
            UI_Manager.instance.bodyParts_Screen.Set_PrevBtn(false);
            UI_Manager.instance.bodyParts_Screen.Set_NextBtn(false);
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
