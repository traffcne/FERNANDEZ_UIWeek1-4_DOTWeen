using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
public class UIAnimationManager : MonoBehaviour
{
    public GameObject YesButton;
    public GameObject NoButton;

    public Vector3 shrinkSize;
    public Vector3 enlargeSize;
    public Vector3 finalDestination;
    public Vector3 initialPointYes;
    public Vector3 initialPointNo;
    public Vector3 rotation;
    
    public float animationDuration;

    public Ease easing;

    

    public void OnClickYes()
    {
        YesButton.transform.DOScale(shrinkSize, animationDuration).OnComplete(()=>YesButton.transform.DOScale(enlargeSize, animationDuration));
    }

    public void OnClickNo()
    {
        NoButton.transform.DOScale(shrinkSize, animationDuration).OnComplete(() => NoButton.transform.DOScale(enlargeSize, animationDuration));
    }

    public void MoveYesButton()
    {
        YesButton.transform.DOLocalMove(finalDestination, animationDuration).SetEase(easing).OnComplete(()=> MoveBackYesButton());
    }

    public void MoveBackYesButton()
    {
        YesButton.transform.DOLocalMove(initialPointYes, animationDuration).SetEase(easing);
    }

    public void MoveNoButton()
    {
        NoButton.transform.DOLocalMove(finalDestination, animationDuration).SetEase(easing).OnComplete(() => MoveBackNoButton());
    }

    public void MoveBackNoButton()
    {
        NoButton.transform.DOLocalMove(initialPointNo, animationDuration).SetEase(easing);
    }

    public void ShakeButton()
    {
        NoButton.transform.DOShakePosition(5, 120, 5, 10);
    }

    //public void FadeButton()
    //{
    //    Image colorButton;
    //    colorButton = NoButton.GetComponent<Image>();
    //    colorButton.DOFade(0,animationDuration);
    //}

    public void RotateButton()
    {
        NoButton.transform.DORotate(rotation, 5f, RotateMode.FastBeyond360);
    }

    public void ButtonJump()
    {
        NoButton.transform.DOLocalJump(finalDestination, 5f, 3, 0.5f);
    }

}
