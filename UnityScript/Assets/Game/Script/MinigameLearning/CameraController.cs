using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    private int currentCamIndex = 0;
    private WebCamTexture tex;
    [SerializeField] private RawImage display;
    private void Start()
    {
        StartCoroutine(DelayProcess());
    }
    private void SwapCam()
    {
        if (WebCamTexture.devices.Length > 0)
        {
            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;
        }
    }
    private void OnDestroy()
    {
        if(tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;
        }
    }
    IEnumerator DelayProcess()
    {
        yield return new WaitForSeconds(1f);
        if (tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;
        }
        else
        {
            WebCamDevice[] cam_devices = WebCamTexture.devices;
            Debug.Log(cam_devices[1].name);
            //WebCamDevice device = WebCamTexture.devices[1];
            tex = new WebCamTexture(cam_devices[1].name);
            display.texture = tex;
            tex.Play();
        }
    }
}
