using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{

    [SerializeField]
    private Text SureText;

    GameManager gameManager;

    private void Awake() {
        gameManager = Object.FindObjectOfType<GameManager>();
    }

    



    int kalanSure;

    bool sureSaysinmi = true;

 
    void Start()
    {
        sureSaysinmi = true;
        kalanSure = 10;
        
    }

    public void SureyiBaslat() {
        StartCoroutine(SureTimerRoutine());

    }


      IEnumerator SureTimerRoutine()
    {
        while(sureSaysinmi)
        {
            yield return new WaitForSeconds(1f);

            if(kalanSure<10){
                 SureText.text = "0"+kalanSure.ToString();
            }
            else
            {
                 SureText.text = kalanSure.ToString();
            }

            kalanSure--;

            if(kalanSure<=0){
                sureSaysinmi = false;
                SureText.text = "";
                gameManager.OyunuBitir();
                
            }
            
        }
    }

}
