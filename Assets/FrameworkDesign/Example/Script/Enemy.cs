using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrameWorkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        public GameObject GamePassPanel;

        /// <summary>
        /// ��ɱ���� 
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
        /// ����Լ�������
        /// </summary>
        private void OnMouseDown()
        {
            Destroy(gameObject);
            mKillCount++;
            if (mKillCount == 10)
            {
                // ��ʾ��Ϸͨ�ؽ���
                GamePassPanel.SetActive(true);
            }
        }
    }
}                        