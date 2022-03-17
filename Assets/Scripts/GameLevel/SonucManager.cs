using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SonucManager : MonoBehaviour
{
    [SerializeField]
    private Text dogruAdetTxt,yanlisAdetTxt,puanTxt;

    GameManager gameManager;

    int puanSure = 10;
    int toplamPuan,yazdirilacakPuan,artisPuani;
    bool sureBittimi = true;

    private void Awake() {
        sureBittimi = true;
        
    }

    IEnumerator PuaniYazdirRoutine(){
        while(sureBittimi){
            yield return new WaitForSeconds(0.1f);
            yazdirilacakPuan += artisPuani;

            if(yazdirilacakPuan>=toplamPuan){
                yazdirilacakPuan = toplamPuan;
            }
            puanTxt.text = yazdirilacakPuan.ToString();

            if(puanSure<=0){
                sureBittimi = false;
            }

            puanSure --;

        }
    }


    public void SonuclariGoster (int dogruAdet,int yanlisAdet,int puan){
        dogruAdetTxt.text = dogruAdet.ToString();
        yanlisAdetTxt.text = yanlisAdet.ToString();
        puanTxt.text = puan.ToString();

        toplamPuan = puan;
        artisPuani = toplamPuan / 10;

        StartCoroutine(PuaniYazdirRoutine());
    }

    public void SonucTekrarOyna(){
        SceneManager.LoadScene("GameLevel");
    }
    public void SonucAnaMenuyeDon(){
        SceneManager.LoadScene("MenuLevel");
    }



    void Start()
    {
        
    }


}
