using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {

    public Text Outro;
    public string SceneToLoad;

    private void OnTriggerEnter(Collider collision)
    {
        
        StartCoroutine("Wait");
        
    }

    IEnumerator Wait()
    {
        Outro.enabled = true;
        yield return new WaitForSeconds(1);
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(SceneToLoad);
    }
}
