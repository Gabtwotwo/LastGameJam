using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winText : MonoBehaviour
{
    [SerializeField]
    private Text text;

    // Update is called once per frame
    void Update()
    {
        switch (PlayerPrefs.GetInt("Ending"))
        {
            case 1:
                text.text = "Your environment impacted your X axis, \n" +
                            " you got some foggy glasses, \n" +
                            " and you are a patient person. (Ending 1 of 8)";
                break;
            case 2:
                text.text = "Your environment impacted your X axis, \n" +
                            " you got some foggy glasses, \n" +
                            " and you are a creative person. (Ending 2 of 8)";
                break;
            case 3:
                text.text = "Your environment impacted your Y axis, \n" +
                            " you enjoy what could be, and the science fiction, \n" +
                            " and you are a well rounded person. (Ending 3 of 8)";
                break;
            case 4:
                text.text = "Your environment impacted your Y axis, \n" +
                            " you enjoy what could be, and the science fiction, \n" +
                            " and you are a by the books person. (Ending 4 of 8)";
                break;
            case 5:
                text.text = "Your environment impacted your X axis, \n" +
                            " you find enjoyment in following rules, \n" +
                            " and you are simply a kid at heart. (Ending 5 of 8)";
                break;
            case 6:
                text.text = "Your environment impacted your X axis, \n" +
                            " you find enjoyment in following rules, \n" +
                            " and you accept change quite well. (Ending 6 of 8)";
                break;
            case 7:
                text.text = "Your environment impacted your Y axis, \n" +
                            " you are fast paced, motivated, \n" +
                            " and you take time appreciating things. (Ending 7 of 8)";
                break;
            case 8:
                text.text = "Your environment impacted your Y axis, \n" +
                            " you are fast paced, motivated, \n" +
                            " and you take pride in being unique. (Ending 8 of 8)";
                break;

              

        }
        if (PlayerPrefs.GetInt("Ending1Earned") == 1 && PlayerPrefs.GetInt("Ending2Earned") == 1 && PlayerPrefs.GetInt("Ending3Earned") == 1 && PlayerPrefs.GetInt("Ending4Earned") == 1 && PlayerPrefs.GetInt("Ending5Earned") == 1 && PlayerPrefs.GetInt("Ending6Earned") == 1 && PlayerPrefs.GetInt("Ending7Earned") == 1 && PlayerPrefs.GetInt("Ending8Earned") == 1)
        {
            text.text = text.text + "\n YOU ARE AMAZING!";
        }


    }
}
