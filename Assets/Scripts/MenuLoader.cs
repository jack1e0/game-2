using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void StartFade()
    {
        animator.SetTrigger("FadeBlack");
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}