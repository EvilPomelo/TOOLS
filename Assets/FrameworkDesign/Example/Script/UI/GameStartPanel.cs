using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrameWorkDesign.Example
{
    public class GameStartPanel : MonoBehaviour
    {
        public GameObject Enemies;

        // Start is called before the first frame update
        void Start()
        {
            transform.Find("BtnGameStart").GetComponent<Button>().onClick.AddListener(()=> {
                gameObject.SetActive(false);
                Enemies.SetActive(true);
            });

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}