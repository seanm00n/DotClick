using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cInput : MonoBehaviour
{   
    public void OnClick_001() {
        //MAIN_GAME 클릭 시
        if (!(cVar.I.vApplicationState == cVar.APPLICATION_STATE_MAIN) || !(cVar.I.vCheckApplicationState[cVar.I.vApplicationState] == true)) {
            return;
        }
        cInit.I.Destroy_Main();
        cInit.I.Initialize_Game();
    }
    public void OnClick_002() {
        //MAIN_EXIT 클릭 시
        if (!(cVar.I.vApplicationState == cVar.APPLICATION_STATE_MAIN) || !(cVar.I.vCheckApplicationState[cVar.I.vApplicationState] == true)) {
            return;
        }
        Application.Quit();
    }
    public void OnClick_003() {
        //PAUS 클릭 시
        if (!(cVar.I.vApplicationState == cVar.APPLICATION_STATE_GAME) || !(cVar.I.vCheckApplicationState[cVar.I.vApplicationState] == true)) {
            return;
        }
        cInit.I.Initialize_Pause();
    }
    public void OnClick_004() {
        //PAUS_GAME 클릭 시
        if (!(cVar.I.vApplicationState == cVar.APPLICATION_STATE_PAUS) || !(cVar.I.vCheckApplicationState[cVar.I.vApplicationState] == true)) {
            return;
        }
        cInit.I.Destroy_Pause();
    }
    public void OnClick_005() {
        //PAUS_EXIT 클릭 시
        if (!(cVar.I.vApplicationState == cVar.APPLICATION_STATE_PAUS) || !(cVar.I.vCheckApplicationState[cVar.I.vApplicationState] == true)) {
            return;
        }
        cInit.I.Destroy_Pause();
        cInit.I.Destroy_Game();
        cInit.I.Initialize_Main();
    }
    public void OnClick_006() {
        //GAOV_GAME 클릭 시

    }
    public void OnClick_007() {
        //GAOV_EXIT 클릭 시

    }
    void Update() {
        if(cVar.I.vApplicationState < 0 || cVar.I.vApplicationState >= cVar.MAX_APPLICATION_STATE_NUM) {
            return;
        }
        if (!cVar.I.vCheckApplicationState[cVar.I.vApplicationState]) {
            return;
        }
        switch (cVar.I.vApplicationState) {
            case cVar.APPLICATION_STATE_MAIN:
                cVar.I.sButton.cButton[cVar.BUTTON_MAIN_GAME].onClick.AddListener(OnClick_001);
                cVar.I.sButton.cButton[cVar.BUTTON_MAIN_EXIT].onClick.AddListener(OnClick_002);
                break;
            case cVar.APPLICATION_STATE_GAME:
                cVar.I.sButton.cButton[cVar.BUTTON_PAUS].onClick.AddListener(OnClick_003);
                cVar.I.sButton.cButton[cVar.BUTTON_PAUS_GAME].onClick.AddListener(OnClick_004);
                cVar.I.sButton.cButton[cVar.BUTTON_PAUS_EXIT].onClick.AddListener(OnClick_005);
                break;
            case cVar.APPLICATION_STATE_PAUS://
                break;
            case cVar.APPLICATION_STATE_GAOV:
                break;
        }
    }
}