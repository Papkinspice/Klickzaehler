using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEditor.ShaderGraph;

public class UpCount : MonoBehaviour
{   
    public TMP_Dropdown Dropdown;
    private int Counter = 0;
    public int Mult = 1;
    public TMP_Text Text;

    public Image RingImage;
    public float ResetTime = 10.0f;
    private float elapsedTime;

    public UnityEvent ResetAction;
    

    private bool pressed;
    private int RingAmount;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateText();
    }

    public void StartReset()
    {
        pressed = true;
    }

    public void StopReset()
    {
        pressed = false;
        ResetFill();
    }

    private void UpdateFill()
    {
        if (elapsedTime < ResetTime)
        {
            elapsedTime += Time.deltaTime;
            RingImage.fillAmount = Mathf.Clamp01(elapsedTime / ResetTime);
        }
        else
        {
            RingImage.fillAmount = 1f;
            ResetAction.Invoke();
            //ResetCount();
        }
    }

    private void ResetFill()
    {
        RingAmount = 0;
        RingImage.fillAmount = RingAmount;
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pressed)
        {

            UpdateFill();
        }
    }

    public void Count()
    {
        Counter= Counter+Dropdown.value+1;
        Counter = Counter % 10000;
        UpdateText();
    }

    public void CountMinus()
    {
        Counter= Counter-1;
        Counter = Counter % 10000;
        UpdateText();
    }

    public void ResetCount()
    {
        Counter = 0;
        UpdateText();
    }

    private void UpdateText()
    {
        Text.text = Counter.ToString("0000");
    }

    public int GetCount()
    {
        return Counter;
    }

    public void SetCount(int count)
    {
        Counter = count;
        UpdateText();
    }

    public void SafeCounter()
    {
        PlayerPrefs.SetInt("Counter", GetCount());
    }

    public void LoadCounter()
    {
        SetCount(PlayerPrefs.GetInt("Counter"));
    }

    public Camera mainCamera;
    public Color newColor;

    public Color newColor2;

    public void BackgroundChange()
    {
        mainCamera.backgroundColor = newColor;
    }

    public void BackgroundChange2()
    {
        mainCamera.backgroundColor = newColor2;
    }

    public Text colorChangeFont;

    void Start2(){
        colorChangeFont.color = Color.black;
    }




}