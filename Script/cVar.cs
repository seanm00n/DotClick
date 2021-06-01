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
        public int vPositionX; //좌표x
        public int vPositionY; //좌표y
        public int vAnimationIndex; //애니메이션상태
        public Animator cAnimator; //애니메이터
    }
    public DOT_INFO[] sDot; //점 구조체

    public const int vFPS = 60;
    public int SCORE;

    public const int POSITION_X = 500; //좌표최대치
    public const int POSITION_Y = 300;
    
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

    public const int DOT_COLOR_RED = 0;//색상(다른몬스터)
    public const int DOT_COLOR_GREEN = 1;
    public const int DOT_COLOR_BLUE = 2;
    public const int MAX_DOT_COLOR_NUM = 3;
    public const int MAX_DOT_NUM = 1;

    public const int ANIMATION_IDLE = 0;//출현
    public const int ANIMATION_DEATH = 1;//클릭당함
    public const int MAX_ANIMATION_NUM = 2;
    public string[] vAnimationName;

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

    public void SetAnimation(int tAnimationIndex, ref DOT_INFO tDot)
    {
        int index01;

        if (vAnimationName == null)
        {
            QuitProcess("Error::vAnimationName == null");
            return;
        }

        if (tAnimationIndex < 0 || MAX_ANIMATION_NUM <= tAnimationIndex)
        {
            QuitProcess("Error::tAnimationIndex out of range");
            return;
        }
        tDot.cAnimator.SetBool(vAnimationName[tAnimationIndex], true);
        tDot.vAnimationIndex = tAnimationIndex;

        for (index01 = 0; index01 < MAX_ANIMATION_NUM; index01++)
        {
            if (tAnimationIndex != index01)
                tDot.cAnimator.SetBool(vAnimationName[index01], false);
        }
    }
}
