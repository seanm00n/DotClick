using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cDraw : MonoBehaviour
{
    void Update() {
        int index01;
        if(cVar.I.vApplicationState < 0 || cVar.I.vApplicationState >= cVar.MAX_APPLICATION_STATE_NUM) {
            return;
        }
        if (!cVar.I.vCheckApplicationState[cVar.I.vApplicationState]) {
            return;
        }
        switch (cVar.I.vApplicationState) {
            case cVar.APPLICATION_STATE_MAIN:
                //Text
                for (index01 = 0; index01 < cVar.MAX_TEXT_NUM; index01++) {
                    cVar.I.sText.cTextGameObject[index01].SetActive(false);
                }
                cVar.I.sText.cTextGameObject[cVar.TEXT_DTCL].SetActive(true);
                cVar.I.sText.cText[cVar.TEXT_DTCL].text = string.Format("Dot Click");
                //
                //Button
                for(index01 = 0; index01 < cVar.MAX_BUTTON_NUM; index01++) {
                    cVar.I.sButton.cButtonGameObject[index01].SetActive(false);
                }
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_MAIN_GAME].SetActive(true);
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_MAIN_EXIT].SetActive(true);
                //
                break;
            case cVar.APPLICATION_STATE_GAME:
                //Text
                for (index01 = 0; index01 < cVar.MAX_TEXT_NUM; index01++) {
                    cVar.I.sText.cTextGameObject[index01].SetActive(false);
                }
                //
                //Button
                for (index01 = 0; index01 < cVar.MAX_BUTTON_NUM; index01++) {
                    cVar.I.sButton.cButtonGameObject[index01].SetActive(false);
                }
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_PAUS].SetActive(true);
                //
                break;
            case cVar.APPLICATION_STATE_PAUS:
                //Text
                for (index01 = 0; index01 < cVar.MAX_TEXT_NUM; index01++) {
                    cVar.I.sText.cTextGameObject[index01].SetActive(false);
                }
                cVar.I.sText.cTextGameObject[cVar.TEXT_PAUS].SetActive(true);
                cVar.I.sText.cText[cVar.TEXT_PAUS].text = string.Format("Pause");
                //
                //Button
                for (index01 = 0; index01 < cVar.MAX_BUTTON_NUM; index01++) {
                    cVar.I.sButton.cButtonGameObject[index01].SetActive(false);
                }
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_PAUS_GAME].SetActive(true);
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_PAUS_EXIT].SetActive(true);
                //
                break;
            case cVar.APPLICATION_STATE_GAOV:
                //Text
                for (index01 = 0; index01 < cVar.MAX_TEXT_NUM; index01++) {
                    cVar.I.sText.cTextGameObject[index01].SetActive(false);
                }
                cVar.I.sText.cTextGameObject[cVar.TEXT_GAOV].SetActive(true);
                cVar.I.sText.cText[cVar.TEXT_GAOV].text = string.Format("GameOver");
                //
                //Button
                for (index01 = 0; index01 < cVar.MAX_BUTTON_NUM; index01++) {
                    cVar.I.sButton.cButtonGameObject[index01].SetActive(false);
                }
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_GAOV_GAME].SetActive(true);
                cVar.I.sButton.cButtonGameObject[cVar.BUTTON_GAOV_EXIT].SetActive(true);
                //
                break;
        }
    }
}
