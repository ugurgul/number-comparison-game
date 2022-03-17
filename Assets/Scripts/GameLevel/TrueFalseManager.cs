using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrueFalseManager : MonoBehaviour
{

    [SerializeField]
    private GameObject trueIcon,falseIcon;





    void Start()
    {
       trueIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
       falseIcon.GetComponent<RectTransform>().localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator DogruIconGosterRoutine(bool dogruMu)

    {
        if(dogruMu){
        trueIcon.GetComponent<RectTransform>().DOScale(1,0.2f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.2f);
        trueIcon.GetComponent<RectTransform>().DOScale(0,0.2f).SetEase(Ease.InBack);
        }
        else
        {
        falseIcon.GetComponent<RectTransform>().DOScale(1,0.2f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(0.2f);
        falseIcon.GetComponent<RectTransform>().DOScale(0,0.2f).SetEase(Ease.InBack);
        }
        
    }
}
