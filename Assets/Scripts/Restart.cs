using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void PressButton()
    {
        SceneManager.LoadScene(0);
        GameObject.Find("Canvas").transform.GetChild(0).gameObject.SetActive(true);
    }
}
