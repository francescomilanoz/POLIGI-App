﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(Loadscene);
    }

    private void Loadscene()
    {
        SceneManager.LoadScene("01waitinline");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
