using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public float captureAngle = 20;

    public bool isHit;

    private float rotX;

    private void Update()
    {
        rotX = Mathf.Abs(Player.Instance.transform.rotation.eulerAngles.x);
    }

    public void OnButtonClick()
    {
        if ((rotX < captureAngle || (rotX < 90 && rotX > 90 - captureAngle) || (rotX < 270 && rotX > 270 - captureAngle) || rotX > 360 - captureAngle) && !isHit)
        {
            isHit= true;
            Counter.Instance.IncreseCounter();
            StartCoroutine(ResetHit());
        }
    }

    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(captureAngle * 0.025f);
        isHit = false;
    }
}
