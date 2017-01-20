using UnityEngine;
using System.Collections;

public class cameraobject : MonoBehaviour {

    // Use this for initialization
    int requestedWidth = 480;
    int requestedHeight = 854;

    WebCamTexture webcamTexture;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length > 0)
        {
            // コンストラクタでwebcamTextureを作成
            webcamTexture = new WebCamTexture(requestedWidth, requestedHeight);
            // 映し先のTextureにwebcamTextureを渡す
            GetComponent<UnityEngine.UI.Image>().material.mainTexture = webcamTexture;
            // 実行する
            webcamTexture.Play();
        }
        else {
            Debug.Log("カメラないよ");
            return;
        }
    }

    public void StopCamera()
    {
        // カメラを止める
        webcamTexture.Stop();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
