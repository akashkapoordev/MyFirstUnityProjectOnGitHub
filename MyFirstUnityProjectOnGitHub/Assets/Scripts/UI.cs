using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button back_button;

    public string main_scene;
    public string scene1;
    public string scene2;
    public string scene3;

    private void Start()
    {
        if(button1 != null && button2 != null && button3!=null)
        {
            button1.onClick.AddListener(() => sceneChange(scene1));
            button2.onClick.AddListener(() => sceneChange(scene2));
            button3.onClick.AddListener(() => sceneChange(scene3));
        }

        if(back_button!= null)
        {
            back_button.onClick.AddListener(() => sceneChange(main_scene));

        }
    }

    void sceneChange(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
