using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Obi


{ 
    public class OVR_touch : MonoBehaviour
    {
        public ObiEmitter ObiEmitte_A;

        public ObiEmitter ObiEmitte_X;

        // Start is called before the first frame update
        void Start()
        {
            ObiEmitte_A.speed = 0f;
            ObiEmitte_X.speed = 0f;
        }

        // Update is called once per frame
        void Update()
        {

            // 右コントローラーのAボタンが押された時の処理
            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch))
            {
  
                ObiEmitte_A.speed = 0.1f;
            }
            else
            {

                ObiEmitte_A.speed = 0f;
            }

            if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.Touch))
            {
                Restart();

            }





            // 左コントローラーのXボタンが押された時の処理
            if (OVRInput.GetDown(OVRInput.Button.Three, OVRInput.Controller.Touch))
            {


                ObiEmitte_X.speed = 0.1f;
            }
            else
            {

                ObiEmitte_X.speed = 0f;
            }

        }

        private void Restart()
        {


            // 現在のScene名を取得する
            Scene loadScene = SceneManager.GetActiveScene();
            // Sceneの読み直し
            SceneManager.LoadScene(loadScene.name);
        }
    }
}