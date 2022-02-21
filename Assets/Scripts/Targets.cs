using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public static bool IsPlayable;

    public GameObject WinPanel;
    public GameObject LosePanel;

    // Start is called before the first frame update
    void Start()
    {
        WinPanel.SetActive(false);
        LosePanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreCounter.TargetsReached == 11 && ScoreCounter.CurrentTime != 0)
        {
            WinPanel.SetActive(true);
            LosePanel.SetActive(false);
        }

        else if(ScoreCounter.TargetsReached != 11 && ScoreCounter.CurrentTime <= 0)
        {
            WinPanel.SetActive(false);
            LosePanel.SetActive(true);
        }
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && IsPlayable == true)
        {
            ScoreCounter.TargetsReached ++;
            Destroy(this.gameObject);
        }
    }
}
