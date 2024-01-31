using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IPointerClickHandler
{
    //[SerializeField] float scaleUpAmount = 0.1f; // Amount to scale up the button when hovered over
    //[SerializeField] float scaleDownAmount = 0.9f; // Amount to scale down the button when not hovered over
    public LeanTweenType leanType;

    public void OnPointerClick(PointerEventData eventData)
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        var tween = LeanTween.scale(this.transform.gameObject, new Vector3(.55f, 2.8f, 1), 0.2f)
                .setEase(leanType)
                .setIgnoreTimeScale(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        var tween = LeanTween.scale(this.transform.gameObject, new Vector3(.5f,2.5f, 1), 0.2f)
                 .setEase(leanType)
                 .setIgnoreTimeScale(true);
    }
}