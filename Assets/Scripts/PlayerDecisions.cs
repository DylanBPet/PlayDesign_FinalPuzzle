using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDecisions : MonoBehaviour
{
    public PatientVariables patiantScript;
    public CanvasSwitchingScript canvasScript;


    public Button patient1;
    public bool? patient1Released = null;
    public bool? patient1Medicated = null;

    public Button patient2;
    public bool? patient2Released = null;
    public bool? patient2Medicated = null;

    public Button patient3;
    public bool? patient3Released = null;
    public bool? patient3Medicated = null;

    public Button patient4;
    public bool? patient4Released = null;
    public bool? patient4Medicated = null;

    public Button patient5;
    public bool? patient5Released = null;
    public bool? patient5Medicated = null;

    public Button patient6;
    public bool? patient6Released = null;
    public bool? patient6Medicated = null;

    public Button patient7;
    public bool? patient7Released = null;
    public bool? patient7Medicated = null;

    public Button patient8;
    public bool? patient8Released = null;
    public bool? patient8Medicated = null;

    public Button patient9;
    public bool? patient9Released = null;
    public bool? patient9Medicated = null;

    public Button patient10;
    public bool? patient10Released = null;
    public bool? patient10Medicated = null;

        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PatientRelease()
    {
        if (patiantScript.currentPatient == 1)
        {
            patient1.GetComponent<Image>().color = Color.red;
            patient1Released = true;
            patient1Medicated = false;
        }

        if (patiantScript.currentPatient == 2)
        {
            patient2.GetComponent<Image>().color = Color.red;
            patient2Released = true;
            patient2Medicated = false;
        }
        if(patiantScript.currentPatient == 3)
        {
            patient3.GetComponent<Image>().color = Color.red;
            patient3Released = true;
            patient3Medicated = false;
        }
        if (patiantScript.currentPatient == 4)
        {
            patient4.GetComponent<Image>().color = Color.red;
            patient4Released = true;
            patient4Medicated = false;
        }
        if (patiantScript.currentPatient == 5)
        {
            patient5.GetComponent<Image>().color = Color.red;
            patient5Released = true;
            patient5Medicated = false;
        }
        if (patiantScript.currentPatient == 6)
        {
            patient6.GetComponent<Image>().color = Color.red;
            patient6Released = true;
            patient6Medicated = false;
        }
        if (patiantScript.currentPatient == 7)
        {
            patient7.GetComponent<Image>().color = Color.red;
            patient7Released = true;
            patient7Medicated = false;
        }
        if (patiantScript.currentPatient == 8)
        {
            patient8.GetComponent<Image>().color = Color.red;
            patient8Released = true;
            patient8Medicated = false;
        }
        if (patiantScript.currentPatient == 9)
        {
            patient9.GetComponent<Image>().color = Color.red;
            patient9Released = true;
            patient9Medicated = false;
        }
        if (patiantScript.currentPatient == 10)
        {
            patient10.GetComponent<Image>().color = Color.red;
            patient10Released = true;
            patient10Medicated = false;
        }

    }

    public void PatientMedicated()
    {
        if (patiantScript.currentPatient == 1)
        {
            patient1.GetComponent<Image>().color = Color.green;
            patient1Released = false;
            patient1Medicated = true;
        }

        if (patiantScript.currentPatient == 2)
        {
            patient2.GetComponent<Image>().color = Color.green;
            patient2Released = false;
            patient2Medicated = true;
        }
        if (patiantScript.currentPatient == 3)
        {
            patient3.GetComponent<Image>().color = Color.green;
            patient3Released = false;
            patient3Medicated = true;
        }
        if (patiantScript.currentPatient == 4)
        {
            patient4.GetComponent<Image>().color = Color.green;
            patient4Released = false;
            patient4Medicated = true;
        }
        if (patiantScript.currentPatient == 5)
        {
            patient5.GetComponent<Image>().color = Color.green;
            patient5Released = false;
            patient5Medicated = true;
        }
        if (patiantScript.currentPatient == 6)
        {
            patient6.GetComponent<Image>().color = Color.green;
            patient6Released = false;
            patient6Medicated = true;
        }
        if (patiantScript.currentPatient == 7)
        {
            patient7.GetComponent<Image>().color = Color.green;
            patient7Released = false;
            patient7Medicated = true;
        }
        if (patiantScript.currentPatient == 8)
        {
            patient8.GetComponent<Image>().color = Color.green;
            patient8Released = false;
            patient8Medicated = true;
        }
        if (patiantScript.currentPatient == 9)
        {
            patient9.GetComponent<Image>().color = Color.green;
            patient9Released = false;
            patient9Medicated = true;
        }
        if (patiantScript.currentPatient == 10)
        {
            patient10.GetComponent<Image>().color = Color.green;
            patient10Released = false;
            patient10Medicated = true;
        }
    }

    public void IsPlayerCorrect()
    {
        if(patient1Released == true && patient2Medicated == true && patient3Released == true && patient4Released == true && patient5Released == true && patient6Released == true && patient7Released == true && patient8Released == true && patient9Released == true && patient10Released == true)
        {
            canvasScript.patientRoom.SetActive(false);
            canvasScript.choiceSelection.SetActive(false);
            canvasScript.endScreen.SetActive(true);
        }
    }

}
