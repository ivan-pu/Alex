using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Switch : MonoBehaviour
{
    public bool gender = true;
    [SerializeField]
    private GameObject boyView;
    [SerializeField]
    private GameObject girlView;
    [SerializeField]
    private GameObject ProgressRoot;
    [SerializeField]
    private Image ProgressRing;
    private float switchTime = 2f;
    private float timeEplapsed = 0f;

    private const float interferenceValue = 400;

    private GlitchImageEffect glitchEffect;

    private float cooldownTimer = 0f;

    private Vector3 defaultPosition;
    private Quaternion defaultRotation;


    // Start is called before the first frame update
    void Start()
    {
        GetView();
        glitchEffect = this.gameObject.GetComponent<GlitchImageEffect>();
        defaultPosition = this.transform.parent.position;
        defaultRotation = this.transform.parent.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        GetView();
        if (cooldownTimer > 0f)
        {
            cooldownTimer -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.F) && cooldownTimer <= 0f)
        {
            ProgressRoot.SetActive(true);
            glitchEffect.enabled = true;
            TryIncrementAndComplete();
        }
        else
        {
            ProgressRoot.SetActive(false);
            glitchEffect.enabled = false;
            timeEplapsed = 0f;
        }
        ProgressRing.fillAmount = timeEplapsed / switchTime;
        glitchEffect.interference = interferenceValue * (timeEplapsed / switchTime);
    }

    void TryIncrementAndComplete()
    {
        timeEplapsed += Time.deltaTime;
        if (timeEplapsed >= switchTime)
        {
            gender = !gender;
            timeEplapsed = 0f;
            cooldownTimer = 3f;
            // reset position to default
            this.transform.parent.position = defaultPosition;
            this.transform.parent.rotation = defaultRotation;
            PixelCrushers.DialogueSystem.Sequencer.Message("Switched");
            PixelCrushers.DialogueSystem.DialogueManager.StartConversation(gender ? "Random Switch Dialogue Boy":"Random Switch Dialogue Girl");
        }
    }
    void GetView()
    {
        if (gender)
        {
            boyView.SetActive(true);
            girlView.SetActive(false);
        }
        if (!gender)
        {
            boyView.SetActive(false);
            girlView.SetActive(true);
        }
    }
}
