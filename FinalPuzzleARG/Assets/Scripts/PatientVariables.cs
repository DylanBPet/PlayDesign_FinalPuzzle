using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PatientVariables : MonoBehaviour
{
    //thePatient in the patient room
    public Image patient;
    //the SPEACH BUBBLE text in patient room
    public TextMeshProUGUI speechBubble;
    //the list of symptoms 
    public TextMeshProUGUI symptoms;
    //Tracking what patient you are on with an int
    public int currentPatient;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void patient1()
    {
        currentPatient = 1;
        patient.color = Color.red;
        speechBubble.text = ("Hello, I am Patient 1");
        symptoms.text = ("-sore throat" +
                         " -Cough");
    }

    public void patient2()
    {
        currentPatient = 2;
        patient.color = Color.yellow;
        speechBubble.text = ("Hello, I am Patient 2");
        symptoms.text = ("-Rashes" + 
                         " -Fever");
    }

}
