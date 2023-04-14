using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class VolumeSlider : MonoBehaviour
{
    [SerializeField] string _volumeParameter = "MusicVolume";
    [SerializeField] AudioMixer _mixer;
    [SerializeField] Slider _slider;
    [SerializeField] float _multiplier = 40f;

    public void Awake()
    {
        _slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    private void HandleSliderValueChanged(float value)
    {
        _mixer.SetFloat(_volumeParameter, value:Mathf.Log10(value) * _multiplier);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
