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
    public TextMeshProUGUI symptom1;
    public TextMeshProUGUI symptom2;
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
        //insert character sprite here
        patient.color = Color.red;
        //here ^ for each patient
        speechBubble.text = ("I’ve been bleeding out way more than usual. My flow isn’t usually this heavy. Rate my pain? Probably 5/10");
        symptom1.text = ("-Heavier Flow");
        symptom2.text =("-Pain 5/10");
    }

    public void patient2()
    {
        currentPatient = 2;
        patient.color = Color.yellow;
        speechBubble.text = ("Sometimes, it hurts so bad, I can’t even walk. And my cycle is way shorter, like I’ve been getting my period every 2 weeks. That can’t be normal. If I had to rate my pain it’d be a 10/10. I even feel it in my legs.");
        symptom1.text = ("-2 Week Cycle");
        symptom2.text = ("-Pain 10/10");
    }

    public void patient3()
    {
        currentPatient = 3;
        patient.color = Color.blue;
        speechBubble.text = ("I.. Haven’t had my period in like 6 months. I’m not pregnant. I know I’m not. Pain? Well, I haven’t had any.");
        symptom1.text = ("-Late Period");
        symptom2.text = ("-Pain 0/10");
    }

    public void patient4()
    {
        currentPatient = 4;
        patient.color = Color.green;
        speechBubble.text = ("My cycle has been pretty irregular. I think it was 20 days, then 2 months, then 4 months, then last week. Is this normal? Rate my pain? I don’t really get period cramps so 0, I guess.");
        symptom1.text = ("-Irregular Cycle");
        symptom2.text = ("-Pain 0/10");
    }

    public void patient5()
    {
        currentPatient = 5;
        patient.color = Color.black;
        speechBubble.text = ("I’ve been getting really nauseous every time I get my period. Like throwing up almost every day of my period.");
        symptom1.text = ("-Nauseous,  Vomiting");
        symptom2.text = ("-Pain 4/10");
    }

    public void patient6()
    {
        currentPatient = 6;
        patient.color = Color.gray;
        speechBubble.text = ("I feel like my cramps have been worse than usual. Normally, they’re pretty tolerable, but I recently had to take a day off work cause of it. If I had to rate it, normally it’s around a 4/10, but now it’s an 8/10.");
        symptom1.text = ("-Normal Pain 4/10");
        symptom2.text = ("-Currently 8/10");
    }

    public void patient7()
    {
        currentPatient = 7;
        patient.color = Color.cyan;
        speechBubble.text = ("I always feel so tired in the days leading up to my period. I also get the craziest migraines. I think I’d rate the pain around 7/10.");
        symptom1.text = ("-Migraines");
        symptom2.text = ("-Pain 7/10");
    }

    public void patient8()
    {
        currentPatient = 8;
        patient.color = Color.magenta;
        speechBubble.text = ("My period cramps have been hurting a lot more than usual. I’ve been taking ibuprofen, but they haven’t been getting any better.");
        symptom1.text = ("-Painful  Cramps");
        symptom2.text = ("-Pain 6/10");
    }

    public void patient9()
    {
        currentPatient = 9;
        patient.color = Color.white;
        speechBubble.text = ("Lately, my periods have been looking kind of brown and clumpy. Even a little black. Is that normal? ");
        symptom1.text = ("-Discoloured Discharge");
        symptom2.text = ("-1/10");
    }

    public void patient10()
    {
        currentPatient = 10;
        patient.color = Color.green;
        speechBubble.text = ("I feel like it’s been smelling worse than usual down there whenever I start my period. I know it’s normal for period blood to small weird, but how do I put this. It smells almost rotten.");
        symptom1.text = ("-Unusual Smell");
        symptom2.text = ("-2/10");
    }
}
