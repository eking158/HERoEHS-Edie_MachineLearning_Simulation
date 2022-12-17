//rostopic pub /edie/output  -1  std_msgs/Int32MultiArray "data: [1, 8, 2]" 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace RosSharp.RosBridgeClient
{
    public class sub_output : UnitySubscriber<MessageTypes.Std.Int32MultiArray>
    {
        public TextMeshProUGUI show_edie_datas;
        private bool isMessageReceived;
        float edie_face, edie_motion, edie_voice;

        protected override void Start()
        {
            base.Start();
        }

        protected override void ReceiveMessage(MessageTypes.Std.Int32MultiArray message)
        {
            edie_face = message.data[0];
            edie_motion = message.data[1];
            edie_voice = message.data[2];
            isMessageReceived = true;
        }

        private void Update()
        {
            if (isMessageReceived)
                ProcessMessage();
        }
        
        private void ProcessMessage()
        {
            show_edie_datas.text = "Edie Face: "+edie_face+"\n"+"Edie Motion: "+edie_motion+"\n"+"Edie Voice: "+edie_voice;
            Debug.Log("Got Message");

            isMessageReceived = false;
        }
    }
}
