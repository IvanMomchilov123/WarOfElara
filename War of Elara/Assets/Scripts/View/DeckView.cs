using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckView : MonoBehaviour
{
    public Animator deckImageAnimator;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (GetComponentInChildren<Image>().enabled)
            {
                deckImageAnimator.SetTrigger("close");
                PlaySlidingSoundEffect();
            }
    }



    public void PlaySlidingSoundEffect()
    {
        audioSource.Play();
    }
}
