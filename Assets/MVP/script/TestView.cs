﻿using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// modelにあるヒットポイントの値が変更されたときpresenterを経由してUIに反映する。
/// </summary>
public class TestView : MonoBehaviour
{
    [SerializeField, Tooltip("ヒットポイントのスライダー")]
    private Slider _slider;

    /// <summary>
    /// スライダーの最大値を設定
    /// </summary>
    public void Init(int maxHealth)
    {
        _slider.maxValue = maxHealth;
    }

    /// <summary>
    /// ヒットポイントの値をスライダーに反映
    /// </summary>
    public void HealthSlider(float value)
    {
        _slider.value = value;
    }

}
