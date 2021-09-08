using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectBall : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI tmpText;
    // Start is called before the first frame update
    void Start()
    {
        tmpText.text = "Score :\n" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            score += 1;
            tmpText.text = "Score :\n" + score.ToString();
        }
    }
}
