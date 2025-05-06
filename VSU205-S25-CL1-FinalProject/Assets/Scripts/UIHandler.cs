using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] GameObject UICanvas;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UICanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideUI()
    {
        UICanvas.SetActive(false);
        Debug.Log("Hide UI");
    }

    public void ShowUI()
    {
        UICanvas.SetActive(true);
        Debug.Log("Show UI");
    }
    
    
    //TODO: MAKE THE BUTTON BE THE ONE THAT CALLS GET INFO 
    
    //TODO: HAVE THE HIGHSCORE LIST BE SHOWN AT THE BEGINNING OF THE GAME
    
}
