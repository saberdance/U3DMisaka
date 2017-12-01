using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisakaMove : MonoBehaviour {

    public int MisakaSpeed = 10;

    private Animator m_animator;

	// Use this for initialization
	void Start () {
        m_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ResetKeyState();
            m_animator.SetBool("bUpKeyDown", true);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ResetKeyState();
            m_animator.SetBool("bDownKeyDown", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ResetKeyState();
            m_animator.SetBool("bLeftKeyDown", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ResetKeyState();
            m_animator.SetBool("bRightKeyDown", true);
        }
        //transform.Translate(Vector3.down * MisakaSpeed * Time.deltaTime);
    }

    void ResetKeyState()
    {
        m_animator.SetBool("bUpKeyDown", false);
        m_animator.SetBool("bDownKeyDown", false);
        m_animator.SetBool("bLeftKeyDown", false);
        m_animator.SetBool("bRightKeyDown", false);
    }
}
