using UnityEngine;

public class CanvasSwitchingScript : MonoBehaviour
{

    //the canvas for choice selection
    public GameObject choiceSelection;

    //the canvas for the patient room
    public GameObject patientRoom;

    //canvas for when player finishes puzzle
    public GameObject endScreen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        patientRoom.SetActive(false);
        choiceSelection.SetActive(false);
        endScreen.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }


    public void ToChoiceSelection()
    {
        patientRoom.SetActive(false);
        choiceSelection.SetActive(true);
    }

    public void ToPatientRoom()
    {
        choiceSelection.SetActive(false);
        patientRoom.SetActive(true);
    }
}
