using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission : MonoBehaviour
{
    public Sprite completeSprite;
    public Sprite notCompleteSprite;
    public hardcoder Hardcoder;
    public Image missionCompleteLogo;
    
    void Update()
    {
        if (Hardcoder.GetCount() > 2)
        {
            missionCompleteLogo.sprite = completeSprite;
        }    
    }
}
