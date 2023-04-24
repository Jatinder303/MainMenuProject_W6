using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressBarScript : MonoBehaviour
{
    private Slider slider;
    private float Targertprogress = 0;
    public float fillSpeed = 0.1f;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        incrementProgress(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < Targertprogress)
        {
            slider.value += fillSpeed * Time.deltaTime;
        }
        else
        {
            SceneManager.LoadScene(2);
        }
    }

    //add progress to the bar
    public void incrementProgress(float newProgress)
    {
        Targertprogress = slider.value + newProgress;
    }
}
