using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
     [SerializeField]
     private Transform kafa;
     [SerializeField]
     private Transform startBtn;

     public void StartGame(){
         SceneManager.LoadScene("GameLevel");
     }

   




    void Start()
    {
        kafa.transform.GetComponent<RectTransform>().DOLocalMoveX(0f,1f).SetEase(Ease.OutBack);
        startBtn.transform.GetComponent<RectTransform>().DOMoveY(30f,1f).SetEase(Ease.OutBack);
    }


}
