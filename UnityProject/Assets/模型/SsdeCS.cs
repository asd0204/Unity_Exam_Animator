using UnityEngine;

public class SsdeCS : MonoBehaviour
{
    private Animator m_Animator;



    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        m_Animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            m_Animator.SetTrigger("跳舞觸發");
        m_Animator.SetBool("跑步開關", Input.GetKey(KeyCode.R));

    }
}

