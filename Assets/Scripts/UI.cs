using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public InputField textCooldown;
    public InputField textSpeed;
    public InputField textDistanse;

    private bool check;
    private Text textError;

    private void Start()
    {
        textSpeed = GameObject.Find("InputFieldSpeed").GetComponent<InputField>();
        textCooldown = GameObject.Find("InputFieldCooldown").GetComponent<InputField>();
        textDistanse = GameObject.Find("InputFieldDistanse").GetComponent<InputField>();

        DontDestroyOnLoad(gameObject);

        textError = GameObject.Find("TextError").GetComponent<Text>();

    }
    public void PressStart()
    {
        Check();

        if (check)
        {
            SceneManager.LoadScene(1);
            GameObject.Find("Panel").SetActive(false);
        }

    }

    private void Check()
    {

        if (int.Parse(textDistanse.text) > 0 && int.Parse(textCooldown.text) > 0 && (int.Parse(textSpeed.text) > 0))
        {
            check = true;
        }
        else
        {
            textError.text = "Все числа должно быть больше 0";
        }
    }

}
