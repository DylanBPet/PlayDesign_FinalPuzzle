using TMPro;
using UnityEngine;

public class InputFieldGrabber : MonoBehaviour
{
    public GameObject passwordFeedback;
    public TextMeshProUGUI feedback;
    public TMP_InputField inputText;

    public GameObject goToChoiceSelectionButton;

    public CanvasSwitchingScript switchingCanvas;

    public GameObject passwordScene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        passwordScene.SetActive(true);
        passwordFeedback.SetActive(false);
        goToChoiceSelectionButton.SetActive(false);
        feedback = passwordFeedback.GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WasPasswordCorrect()
    {
        if(inputText.text == "Endometriosis" || inputText.text == "endometriosis")
        {
            passwordFeedback.SetActive(true);
            goToChoiceSelectionButton.SetActive(true);
            feedback.text = "Correct, Continue";
            feedback.color = Color.green;
        }
        else
        {
            passwordFeedback.SetActive(true);
            feedback.text = "Incorrect, Try Again";
            feedback.color = Color.red;
        }


    }

    public void PasswordGoodGoToChoiceSelection()
    {
        switchingCanvas.choiceSelection.SetActive(true);
        passwordScene.SetActive(false);
    }

}
