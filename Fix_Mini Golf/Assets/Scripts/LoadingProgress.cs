using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingProgress : MonoBehaviour
{
    [SerializeField] Image image;

    public void Start()
    {
        StartCoroutine(Progress());
    }

    IEnumerator Progress()
    {
        image.fillAmount = 0;
        yield return new WaitForSeconds(1);

        var asyncOp = SceneManager.LoadSceneAsync(SceneLoader.SceneToLoad);

        while (asyncOp.isDone == false)
        {
            image.fillAmount = asyncOp.progress;
            Debug.Log(asyncOp.progress * 100);
            yield return null;
        }
    }
}
