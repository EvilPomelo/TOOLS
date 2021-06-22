using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWorkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        public GameObject GamePassPanel;

        /// <summary>
        /// 击杀数量 
        /// </summary>
        private static int mKillCount = 0;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// 点击自己则销毁
        /// </summary>
        private void OnMouseDown()
        {
            Destroy(gameObject);
            mKillCount++;
            if (mKillCount == 10)
            {
                // 显示游戏通关界面
                GamePassPanel.SetActive(true);
            }
        }
    }
}                        