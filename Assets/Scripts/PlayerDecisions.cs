using UnityEngine;
using UnityEngine.UI;

public class PlayerDecisions : MonoBehaviour
{
    public PatientVariables patiantScript;

    public Button patient1;
    public bool? parient1Released = null;

    public Button patient2;
    public bool? parient2Released = null;

    public Button patient3;


    public Button patient4;


    public Button patient5;


    public Button patient6;


    public Button patient7;


    public Button patient8;


    public Button patient9;


    public Button patient10;


    public Color greyedOut;
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        greyedOut = new Color(255f, 255f, 255f, 50f);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PatientRelease()
    {
        if (patiantScript.currentPatient == 1)
        {
            patient1.GetComponent<Image>().color = greyedOut;
            parient1Released = true;
            patient1.interactable = false;
        }

        if (patiantScript.currentPatient == 2)
        {
            patient2.GetComponent<Image>().color = greyedOut;
            parient2Released = true;
            patient2.interactable = false;
        }

    }

}
