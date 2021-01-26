using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Obi
{

    public class OVR_R_script : MonoBehaviour
    {

        public ObiEmitter mObiEmitte_A;

        public ObiEmitter mObiEmitte_X;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            // 右コントローラーのAボタンが押された時の処理
            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch))
            {

                mObiEmitte_A.speed = 10f;
            }
            else
            {

                mObiEmitte_A.speed = 0f;
            }



            // 左コントローラーのXボタンが押された時の処理
            if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.Touch))
            {



                mObiEmitte_X.speed = 10f;
            }
            else
            {

                mObiEmitte_X.speed = 0f;
            }

        }
    }
}
