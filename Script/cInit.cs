using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;

public class cInit : MonoBehaviour
{
    static public cInit pInstance;

    static public cInit I
    {
        get
        {
            if (pInstance == null)
            {
                return null;
            }
            return pInstance;
        }
    }

    public bool Initialize()
    {
        int index01;
        //
        //ApplicationState
        cVar.I.vCheckApplicationState = null;
        cVar.I.vCheckApplicationState = new bool[cVar.MAX_APPLICATION_STATE_NUM];
        if (cVar.I.vCheckApplicationState == null) {
            cVar.I.QuitProcess("[Error::vCheckApplicationState == null");
            return false;
        }
        //
        //Canvas
        cVar.I.vCanvasName = "Canvas";
        cVar.I.cCanvasGameObject = null;
        cVar.I.cCanvasGameObject = GameObject.Find(cVar.I.vCanvasName);
        if (cVar.I.cCanvasGameObject == null) {
            cVar.I.QuitProcess("Error::cCanvasGameObject == null");
            return false;
        }
        //
        //Text
        cVar.I.vTextName = "Text";
        cVar.I.sText.cGameObject = null;
        cVar.I.sText.cGameObject = cVar.I.cCanvasGameObject.transform.Find(cVar.I.vTextName).gameObject;
        if (cVar.I.sText.cGameObject == null) {
            cVar.I.QuitProcess("Error::sText.cGameObject == null");
            return false;
        }
        cVar.I.sText.cTextGameObject = null;
        cVar.I.sText.cTextGameObject = new GameObject[cVar.MAX_TEXT_NUM];
        if (cVar.I.sText.cTextGameObject == null) {
            cVar.I.QuitProcess("Error::sText.cTextGameObject == null");
            return false;
        }
        cVar.I.sText.cText = null;
        cVar.I.sText.cText = new Text[cVar.MAX_TEXT_NUM];
        if (cVar.I.sText.cText == null) {
            cVar.I.QuitProcess("sText.cText == null");
            return false;
        }
        for (index01 = 0; index01 < cVar.MAX_TEXT_NUM; index01++) {
            cVar.I.sText.cTextGameObject[index01] = null;
            cVar.I.sText.cTextGameObject[index01] = cVar.I.sText.cGameObject.transform.GetChild(index01).gameObject;
            if (cVar.I.sText.cTextGameObject == null) {
                cVar.I.QuitProcess("Error::sText.cTextGameObject == null");
                return false;
            }
            cVar.I.sText.cText[index01] = null;
            cVar.I.sText.cText[index01] = cVar.I.sText.cTextGameObject[index01].GetComponent<Text>();
            if (cVar.I.sText.cText == null) {
                cVar.I.QuitProcess("Error::sText.cText == null");
                return false;
            }
            cVar.I.sText.cTextGameObject[index01].SetActive(false);
        }
        //
        //Button
        cVar.I.vButtonName = "Button";
        cVar.I.sButton.cGameObject = null;
        cVar.I.sButton.cGameObject = cVar.I.cCanvasGameObject.transform.Find(cVar.I.vButtonName).gameObject;
        if (cVar.I.sButton.cGameObject == null) {
            cVar.I.QuitProcess("Error::sButton.cGameObject == null");
            return false;
        }
        cVar.I.sButton.cButtonGameObject = null;
        cVar.I.sButton.cButtonGameObject = new GameObject[cVar.MAX_BUTTON_NUM];
        if (cVar.I.sButton.cButtonGameObject == null) {
            cVar.I.QuitProcess("Error::sButton.cButtonGameObject == null");
            return false;
        }
        cVar.I.sButton.cButton = null;
        cVar.I.sButton.cButton = new Button[cVar.MAX_BUTTON_NUM];
        if (cVar.I.sButton.cButton == null) {
            cVar.I.QuitProcess("sButton.cButton == null");
            return false;
        }
        for (index01 = 0; index01 < cVar.MAX_BUTTON_NUM; index01++) {
            cVar.I.sButton.cButtonGameObject[index01] = null;
            cVar.I.sButton.cButtonGameObject[index01] = cVar.I.sButton.cGameObject.transform.GetChild(index01).gameObject;
            if (cVar.I.sButton.cButtonGameObject == null) {
                cVar.I.QuitProcess("Error::sButton.cButtonGameObject == null");
                return false;
            }
            cVar.I.sButton.cButton[index01] = null;
            cVar.I.sButton.cButton[index01] = cVar.I.sButton.cButtonGameObject[index01].GetComponent<Button>();
            if (cVar.I.sButton.cButton == null) {
                cVar.I.QuitProcess("Error::sButton.cButton == null");
                return false;
            }
            cVar.I.sButton.cButtonGameObject[index01].SetActive(false);
        }
        //
        Initialize_01_Dot();
        if (!Initialize_Main()) {
            return false;
        }
        return true;
    }

    public bool Initialize_01_Dot() {
        int index01;
        cVar.I.sDot = null;
        cVar.I.sDot = new cVar.DOT_INFO[cVar.MAX_DOT_COLOR_NUM];

        cVar.I.vDotColor = null;
        cVar.I.vDotColor = new string[cVar.MAX_DOT_COLOR_NUM];

        for (index01 = 0; index01 < cVar.MAX_DOT_COLOR_NUM; index01++) {
            cVar.I.sDot[index01].cGameObject = null;
            cVar.I.sDot[index01].cGameObject = GameObject.Find(cVar.I.vDotColor[index01]);
            if (cVar.I.sDot[index01].cGameObject == null) {
                cVar.I.QuitProcess("Error::sDot.cGameObject == null");
                return false;
            }
            cVar.I.sDot[index01].cCollider = null;
            cVar.I.sDot[index01].cCollider = cVar.I.sDot[index01].cGameObject.GetComponent<BoxCollider2D>();
            if (cVar.I.sDot[index01].cCollider == null) {
                cVar.I.QuitProcess("Error::sDot.cCollider == null");
                return false;
            }
        }
 
        return true;
    }
    public bool Initialize_Main(){    
        cVar.I.vApplicationState = cVar.APPLICATION_STATE_MAIN;
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_MAIN] = true;
        return true;
    }
    public void Destroy_Main() {
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_MAIN] = false;
    }
    public bool Initialize_Game() {
        cVar.I.vApplicationState = cVar.APPLICATION_STATE_GAME;
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_GAME] = true;
        return true;
    }
    public void Destroy_Game() {
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_GAME] = false;
    }
    public bool Initialize_Pause() {
        cVar.I.vApplicationState = cVar.APPLICATION_STATE_PAUS;
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_PAUS] = true;
        return true;
    }
    public void Destroy_Pause() {
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_PAUS] = false;
        cVar.I.vApplicationState = cVar.APPLICATION_STATE_GAME;
    }
    public bool Initialize_GameOver() {
        cVar.I.vApplicationState = cVar.APPLICATION_STATE_GAOV;
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_GAOV] = true;
        return true;
    }
    public void Destroy_GameOver() {
        cVar.I.vCheckApplicationState[cVar.APPLICATION_STATE_GAOV] = false;
    }
    void Awake()
    {
        pInstance = null;
        pInstance = this;
        if (pInstance == null)
        {
            cVar.I.QuitProcess("[Error:: pInstance == null]");
            return;
        }
        Application.targetFrameRate = cVar.vFPS;
        Initialize();
    }
}
