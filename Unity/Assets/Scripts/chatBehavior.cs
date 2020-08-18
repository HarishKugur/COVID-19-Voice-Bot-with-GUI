using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chatBehavior : MonoBehaviour
{
    Animator animator;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetButtonDown("Talk")) {
        //     Debug.Log("Talk Button Pressed");
        //     byte[] wavBytes = System.Convert.FromBase64String(audioOutput);
        //     AudioClip audioClip = WavUtil.ToAudioClip(wavBytes, 0);
        //     this.audioSource.clip = audioClip;
        //     StartCoroutine(this.WaitForEnd(audioClip.length));
        // }
    }

    // IEnumerator WaitForEnd(float duration) {
    //      this.animator.SetBool("talking", true);
    //      this.audioSource.Play();
    //      yield return new WaitForSeconds(duration);
    //      this.animator.SetBool("talking", false);
    // }


    public IEnumerator WaitForEnd(AudioClip audioClip)
    {
        this.animator.SetBool("typing", false);
        this.audioSource.clip = audioClip;
        this.animator.SetBool("talking", true);
        this.audioSource.Play();
        yield return new WaitForSeconds(audioClip.length);
        this.animator.SetBool("talking", false);
    }


    public string startAck()
    {
        string _var = "";
        this.animator.SetBool("thinking", true);
        return _var;
    }

      public string stopAck()
    {
        string _var = "";
        this.animator.SetBool("thinking", false);
        this.animator.SetBool("typing", true);
        return _var;
    }
    
      public string startTyping()
    {
        string _var = "";
        this.animator.SetBool("typing", true);
        return _var;
    }

      public string stopTyping()
    {
        string _var = "";
        this.animator.SetBool("typing", false);
        return _var;
    }


}
