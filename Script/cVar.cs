using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class cVar
{
    public struct DOT_INFO
    {
        public GameObject cGameObject; //참조할 오브젝트
        public BoxCollider2D cCollider; //충돌체
    }
    public DOT_INFO[] sDot; //점 구조체

    public const int DOT_COLOR_BLUE = 0;//색상(다른몬스터)
    public const int DOT_COLOR_GREEN = 1;
    public const int DOT_COLOR_RED = 2;
    public const int MAX_DOT_COLOR_NUM = 3;
    public string[] vDotColor;
    public const int MAX_DOT_NUM = 1;

    public struct TIMEGAGE_INFO {
        public GameObject cGameObject; 
    }
    public TIMEGAGE_INFO[] sTimeGage;

    public const int TIMEGAGE_01 = 0;
    public const int TIMEGAGE_02 = 1;
    public const int MAX_TIMEGAGE_NUM = 2;
    public string[] vTimeGage;

    public const int vFPS = 60;
    public int SCORE;

    public const int MAX_POSITION_X = 500; //좌표최대치
    public const int MAX_POSITION_Y = 300;
    
    public const int APPLICATION_STATE_MAIN = 0;//게임 상태
    public const int APPLICATION_STATE_GAME = 1;
    public const int APPLICATION_STATE_GAOV = 2;
    public const int APPLICATION_STATE_PAUS = 3;
    public const int MAX_APPLICATION_STATE_NUM = 4;
    public int vApplicationState;
    public bool[] vCheckApplicationState;

    public string vCanvasName;
    public GameObject cCanvasGameObject;

    public struct TEXT_INFO {
        public GameObject cGameObject;
        public GameObject[] cTextGameObject;        
        public Text[] cText;
    }
    public TEXT_INFO sText;
    public string vTextName;
    public const int TEXT_DTCL = 0;
    public const int TEXT_PAUS = 1;
    public const int TEXT_GAOV = 2;
    public const int MAX_TEXT_NUM = 3;

    public struct BUTTON_INFO {
        public GameObject cGameObject;
        public GameObject[] cButtonGameObject;
        public Button[] cButton;
    }
    public BUTTON_INFO sButton;
    public string vButtonName;
    public const int BUTTON_MAIN_GAME = 0;
    public const int BUTTON_MAIN_EXIT = 1;
    public const int BUTTON_PAUS = 2;
    public const int BUTTON_PAUS_GAME = 3;
    public const int BUTTON_PAUS_EXIT = 4;
    public const int BUTTON_GAOV_GAME = 5;
    public const int BUTTON_GAOV_EXIT = 6;
    public const int MAX_BUTTON_NUM = 7;

    static public cVar pInstance;
    static public cVar I
    {
        get
        {
            if (pInstance != null)
            {
                return pInstance;
            }
            pInstance = new cVar();
            return pInstance;
        }
    }

    public void QuitProcess(string tstring)
    {
        #if UNITY_EDITOR
        Debug.LogError(tstring);
        EditorApplication.ExecuteMenuItem("Edit/Play");
        #else
        Application.Quit();
        #endif
    }
}
