using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Use animation tweening
using DG.Tweening;
public class Button_Manager : MonoBehaviour
{

    public GameObject Test_UI;
    public Vector3 targetPos;
    public float duration;
    public void ButtonMovement()
    {
        Test_UI.transform.DOLocalMove(targetPos, duration).SetEase(Ease.OutQuad);
    }
}
