using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Obi
{

    public class Fluid_ex : MonoBehaviour
    {

        public ObiEmitter mObiEmitter;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButton(0))
            {
                mObiEmitter.speed = 1f;
            }
            else
            {
                mObiEmitter.speed = 0f;
            }



        }
    }

}